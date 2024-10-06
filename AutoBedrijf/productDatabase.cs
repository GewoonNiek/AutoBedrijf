using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBedrijf
{
    internal class productDatabase
    {
        // setup database connection
        private static string connectionString = "server=localhost; user=root; database=autobedrijf; password=";
        MySqlConnection connection = new MySqlConnection(connectionString);

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

        // Get all products from the database
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

        // Get product information using the product name
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

        // Update inventory anmounts
        public void updateInventory(int amountToAdd, string productName)
        {
            connection.Open();
            string query = $"UPDATE `product` SET `amount` = '{amountToAdd}' WHERE `product`.`merk` = '{productName}'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Clone();
            MessageBox.Show("Inventory succesfully updated");
        }


        // Get inventory amounts
        public int getInventory(string productName)
        {
            connection.Open();
            string query = $"Select `amount` from `product` WHERE `product`.`merk` = '{productName}'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            int result = (int)cmd.ExecuteScalar();
            connection.Close();
            return result;
        }
    }
}
