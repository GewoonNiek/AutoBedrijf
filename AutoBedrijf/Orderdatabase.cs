using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBedrijf
{
    internal class Orderdatabase
    {
        private static string connectionString = "server=localhost; user=root; database=autobedrijf; password=";
        MySqlConnection connection = new MySqlConnection(connectionString);
        userDatabase udb = new userDatabase();
        string filepath = "./shoppingcart/shoppingcart.txt";

        public Orderdatabase() { }

        // Adds an order to the database
        public void AddOrderToDB(string email, Form f)
        {
            connection.Open();

            int userid = udb.getUserID(email);

            var lines = File.ReadAllLines(filepath);
            string joinedProductString = null;
            string joinedAmountString = null;
            int totalPrice = 0;

            if (lines.Length > 1)
            {
                foreach (var line in lines)
                {
                    string[] splittedstring = line.Split(';');

                    joinedAmountString += splittedstring[2] + ";";
                    joinedProductString += splittedstring[0] + ";";
                    totalPrice += int.Parse(splittedstring[1]);
                }
            }
            else
            {
                string[] splittedstring = lines[0].Split(';');

                joinedAmountString += splittedstring[2];
                joinedProductString += splittedstring[0];
                totalPrice += int.Parse(splittedstring[1]);
            }

            // Insert the order and retrieve the last inserted ID
            string insertQuery = $"INSERT INTO `order` (`userid`, `products`, `amounts`, `totalprice`) VALUES ('{userid}', '{joinedProductString}', '{joinedAmountString}', '{totalPrice}')";
            MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
            insertCmd.ExecuteNonQuery(); // Execute the insert

            // Now, retrieve the last inserted ID
            string idQuery = "SELECT orderid FROM `order` ORDER BY orderid DESC LIMIT 1;";
            MySqlCommand idCmd = new MySqlCommand(idQuery, connection);

            int newId = Convert.ToInt32(idCmd.ExecuteScalar());

            pdf.CreatePDF(udb.getUserID(email), email, newId);

            connection.Close();

            var form2 = new frmMainMenu(email);
            f.Hide();
            form2.Closed += (s, args) => f.Close();
            form2.Show();
        }

        // Get all orders connected to a specified UserID from the database
        public List<Order> getAllOrdersByID(int userID)
        {
            connection.Open();
            
            List<Order> orders = new List<Order>();

            string query = $"SELECT * FROM `order` WHERE `userid` = {userID}";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Order order  = new Order();
                order.orderid = reader.GetInt32(0);
                order.userid = reader.GetInt32(1);
                order.productstring = reader.GetString(2);
                order.totalPrice = reader.GetInt32(4).ToString();
                order.amountString = reader.GetInt32(3).ToString();
                orders.Add(order);
            }
            reader.Close();

            connection.Close();
            return orders;
        }

        // Get a singular order from database
        public Order getOrderByID(int orderid)
        {
            connection.Open();

            string query = $"SELECT * FROM `order` WHERE `orderid` = {orderid}";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            Order order = new Order();

            while (reader.Read())
            {
                order.orderid = reader.GetInt32(0);
                order.userid = reader.GetInt32(1);
                order.productstring = reader.GetString(2);
                order.totalPrice = reader.GetString(3);
                order.amountString = reader.GetInt32(4).ToString();
            }
            reader.Close();
            connection.Close();

            return order;
        }
    }
}
