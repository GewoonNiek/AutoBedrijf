using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Image = System.Drawing.Image;

namespace AutoBedrijf
{
    internal class database
    {
        // setup database connection
        private static string connectionString = "server=localhost; user=root; database=autobedrijf; password=";
        MySqlConnection connection = new MySqlConnection(connectionString);

        // Function to register an user
        public void registerUser(string name, string email, string password, string confirm_password, string address)
        {
            // Open connection to Database
            connection.Open();
            // Check if passwords match
            if (password.Equals(confirm_password))
            {
                // Generate salt & hash password
                string salt = GenerateSalt();
                password = HashPassword(password, salt);

                // Make a query and run it
                string queryRegisterUser = $"INSERT INTO `user` (`name`, `password`, `address`, `email`, `salt`) VALUES ('{name}','{password}','{address}','{email}','{salt}');";
                MySqlCommand cmd = new MySqlCommand(queryRegisterUser, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User registered!");

            }
            else
            {
                // If passwords dont match show user a messagebox
                MessageBox.Show("Passwords don't match");
            }
            // Close connection
            connection.Close();
        }

        public void loginUser(string email, string password, Form f)
        {
            // Open connection
            connection.Open();

            // Get password and salt from database
            string salt = getSaltFromDB(email);
            string dbPassword = getPasswordFromDB(email);

            // hash inputted password
            string newpassword = HashPassword(password, salt);

            //check if passwords match
            if (newpassword.Equals(dbPassword))
            {
                MessageBox.Show("User logged in succesfully!");
                //open main menu
                f.Hide();
                var form2 = new frmMainMenu(email);
                form2.Closed += (s, args) => f.Close();
                form2.Show();

            } else
            {
                MessageBox.Show("Wrong password!");
            }

            // close connection
            connection.Close();
        }

        // Function to get salt from database
        public string getSaltFromDB(string email)
        {
            // Setup query
            string queryGetSalt = $"SELECT salt FROM `user` WHERE email = '{email}';";
            MySqlCommand cmdGetSalt = new MySqlCommand(queryGetSalt, connection);
            string salt = cmdGetSalt.ExecuteScalar().ToString();

            // Return salt thats in the database
            return salt;
        }

        // Function to get password from database
        public string getPasswordFromDB(string email)
        {
            // Setup query
            string queryGetPassword = $"SELECT password FROM `user` WHERE email = '{email}';";
            MySqlCommand cmdGetPassword = new MySqlCommand(queryGetPassword, connection);
            string dbPassword = cmdGetPassword.ExecuteScalar().ToString();

            // return password thats in the database
            return dbPassword;
        }

        public string HashPassword(string password, string salt)
        {
            // CCombine password with salt
            string combinedString = password + salt;


            // hhas the combined password
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(combinedString));
                return Convert.ToBase64String(hashedBytes);
            }
        }
        public static string GenerateSalt()
        {
            // GGenerate random salt
            byte[] saltBytes = new byte[16];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        // Get role from database
        public int getRole(string email)
        {
            connection.Open();

            string queryGetRole = $"SELECT role FROM `user` WHERE email = '{email}'";
            MySqlCommand cmdGetRole = new MySqlCommand(queryGetRole, connection);
            int dbRole = (int)cmdGetRole.ExecuteScalar();

            connection.Close();
            return dbRole;
        }

        // Add a product to the database
        public void addProductToDB(Image image, string kilometers, string price, string type, string year, decimal amount, Form f, string email)
        {
            connection.Open();

            // Convert the image to a byte array
            byte[] imageBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);  // Convert the image to byte array
                imageBytes = ms.ToArray();
            }

            // Prepare the SQL insert query with placeholders for parameters
            string queryAddProduct = "INSERT INTO `product` (`merk`, `bouwjaar`, `tellerstand`, `prijs`, `amount`, `photo`) " +
                                     "VALUES (@Type, @Year, @Kilometers, @Price, @Amount, @Photo)";

            // Add parameters for each value
            using (MySqlCommand cmdAddProduct = new MySqlCommand(queryAddProduct, connection))
            {
                cmdAddProduct.Parameters.AddWithValue("@Type", type);
                cmdAddProduct.Parameters.AddWithValue("@Year", year);
                cmdAddProduct.Parameters.AddWithValue("@Kilometers", kilometers);
                cmdAddProduct.Parameters.AddWithValue("@Price", price);
                cmdAddProduct.Parameters.AddWithValue("@Amount", amount);

                // Important: Use byte array as a parameter for the image
                cmdAddProduct.Parameters.AddWithValue("@Photo", imageBytes);

                cmdAddProduct.ExecuteNonQuery();
            }

            MessageBox.Show("Product successfully added!");
            connection.Close();

            f.Hide();
            var form2 = new frmMainMenu(email);
            form2.Closed += (s, args) => f.Close();
            form2.Show();
        }



            // Get amount of products in the database
        public int getAmountOfProductsFromDB()
        {
            string queryGetCount = "Count(*) From products";
            MySqlCommand cmdGetCount = new MySqlCommand(queryGetCount, connection);
            int count = cmdGetCount.ExecuteNonQuery();

            return count;
        }

        public List<ProductClass> getAllProducts()
        {
            connection.Open();
            List<ProductClass> products = new List<ProductClass>();

            string query = "Select * from product";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ProductClass productClass = new ProductClass();
                productClass.merk = reader.GetString(1);
                productClass.bouwjaar = reader.GetInt32(2);
                productClass.tellerstand = reader.GetString(3);
                productClass.prijs = reader.GetDouble(4);
                productClass.amount = reader.GetInt32(6);

                long blobLength = reader.GetBytes(5, 0, null, 0, 0);  // Get the length of the BLOB
                if (blobLength > 0)
                {
                    byte[] imageBytes = new byte[blobLength];
                    reader.GetBytes(5, 0, imageBytes, 0, (int)blobLength);  // Read the BLOB into the byte array

                    // Check if the byte array is valid
                    if (imageBytes != null && imageBytes.Length > 0)
                    {
                        // Use MemoryStream to load the image from the byte array
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            productClass.picture = System.Drawing.Image.FromStream(ms);
                        }
                    }
                }

                products.Add(productClass);
            }
            reader.Close();

            return products;
        }

        public ProductClass getProductByName(string productName)
        {
            connection.Open();
            ProductClass productClass = new ProductClass();
            string query = $"Select * from product where merk = '{productName}'";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                productClass.merk = reader.GetString(1);
                productClass.bouwjaar = reader.GetInt32(2);
                productClass.tellerstand = reader.GetString(3);
                productClass.prijs = reader.GetDouble(4);
                productClass.amount = reader.GetInt32(6);

                long blobLength = reader.GetBytes(5, 0, null, 0, 0);  // Get the length of the BLOB
                if (blobLength > 0)
                {
                    byte[] imageBytes = new byte[blobLength];
                    reader.GetBytes(5, 0, imageBytes, 0, (int)blobLength);  // Read the BLOB into the byte array

                    // Check if the byte array is valid
                    if (imageBytes != null && imageBytes.Length > 0)
                    {
                        // Use MemoryStream to load the image from the byte array
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            productClass.picture = System.Drawing.Image.FromStream(ms);
                        }
                    }
                }
            }
            reader.Close();
            connection.Close();
            return productClass;
        }
    }
}
