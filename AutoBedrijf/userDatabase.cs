using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
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
    internal class userDatabase
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
            string queryGetSalt = $"SELECT salt FROM `user` WHERE `user`.`email` = '{email}';";
            MySqlCommand cmdGetSalt = new MySqlCommand(queryGetSalt, connection);
            string salt = cmdGetSalt.ExecuteScalar().ToString();

            // Return salt thats in the database
            return salt;
        }

        // Function to get password from database
        public string getPasswordFromDB(string email)
        {
            // Setup query
            string queryGetPassword = $"SELECT password FROM `user` WHERE `user`.`email` = '{email}';";
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

            string queryGetRole = $"SELECT `role` FROM `user` WHERE email = '{email}'";
            MySqlCommand cmdGetRole = new MySqlCommand(queryGetRole, connection);
            int dbRole = (int)cmdGetRole.ExecuteScalar();

            connection.Close();
            return dbRole;
        }

        // Get user information using email
        public User getUserInfo(string email)
        {
            connection.Open();
            User us = new User();
            string query = $"SELECT * FROM `user` WHERE `user`.`email` = '{email}'";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                us.id = reader.GetInt32(0);
                us.name = reader.GetString(1);
                us.email = reader.GetString(4);
                us.address = reader.GetString(3);
                us.salt = reader.GetString(5);
            }

            reader.Close();
            connection.Close();
            return us;
        }

        // Update user information in database
        public void ChangeUser(int id, string name, string email, string password, string salt, string address)
        {
            connection.Open();
            password = HashPassword(password, salt);
            string query = $"UPDATE `user` SET `name` = '{name}', `address` = '{address}', `email` = '{email}', `password` = '{password}'  WHERE `user`.`id` = {id}";
            MySqlCommand cmd = new MySqlCommand( query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("User succesfully updated!");

        }

        // get all users from database
        public List<User> getAllUsers()
        {
            connection.Open();
            List<User> users = new List<User>();

            string query = "Select * from user";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                User us = new User();

                us.id = reader.GetInt32(0);
                us.name = reader.GetString(1);
                us.email = reader.GetString(4);
                us.address = reader.GetString(3);
                us.salt = reader.GetString(5);
                users.Add(us);
            }
            reader.Close();
            connection.Close();

            return users;
        }

        // Get a list of users that are not an administrator
        public List<User> getUsersWithoutAdmin()
        {
            connection.Open();
            List<User> users = new List<User>();

            string query = "SELECT * FROM user WHERE `user`.`role` = 0";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                User us = new User();

                us.id = reader.GetInt32(0);
                us.name = reader.GetString(1);
                us.email = reader.GetString(4);
                us.address = reader.GetString(3);
                us.salt = reader.GetString(5);
                users.Add(us);
            }
            reader.Close();
            connection.Close();

            return users;
        }

        // get the user id, using the email that is logged in with
        public int getUserID(string email)
        {
            int id = 0;
            if(connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            string query = $"SELECT `id` FROM `user` WHERE email = @Email";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            // Use parameterized queries to prevent SQL injection
            cmd.Parameters.AddWithValue("@Email", email);

            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                id = r.GetInt32(0);
            }
            r.Close();
            
            return id;
        }

        // delete a user (Admin only)
        public void deleteUser(string email)
        {
            connection.Open();
            int userID = this.getUserID(email);
            string query = $"DELETE FROM `user` WHERE `user`.`id` = '{userID}'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        // Get the username of a person
        public string getUsername(string email)
        {
            connection.Open();
            string query = $"SELECT `name` FROM `user` where `user`.`email` = '{email}'";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            string result = cmd.ExecuteScalar().ToString();
            connection.Close();

            return result;

        }
    }
}
