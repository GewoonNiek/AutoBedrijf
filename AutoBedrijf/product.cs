using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBedrijf
{
    public partial class frmProduct : Form
    {
        double totalPrice;
        string email;
        string productName;
        ProductClass pc;
        productDatabase db = new productDatabase();
        string filepath = "./shoppingcart/shoppingcart.txt";
        string joinedString;

        bool clickable = true;

        public frmProduct(string productName, string email)
        {
            // fill in all fields
            InitializeComponent();
            this.email = email;
            this.productName = productName;
            pc = db.getProductByName(productName);
            pbProductImage.Image = pc.picture;
            lblBuildYear2.Text = pc.bouwjaar.ToString();
            lblName2.Text = pc.merk;
            lblPrice2.Text = pc.prijs.ToString();
            lblKilometer2.Text = pc.tellerstand.ToString();
            numAmount.Maximum = pc.amount;
        }

        // return to main menu
        private void btnReturn_Click(object sender, EventArgs e)
        {
            var form2 = new frmMainMenu(email);
            this.Hide();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        // Add product to cart
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (clickable)
            {
                joinedString = lblName2.Text + ";" + lblTotalPrice2.Text.Split(' ')[1] + ";" + numAmount.Value;

                if (!File.Exists(filepath))
                {
                    File.Create(filepath);
                    File.WriteAllText(filepath, joinedString + Environment.NewLine);
                }
                else
                {
                    var lines = File.ReadAllLines(filepath);

                    bool productExists = lines.Any(line => line.Split(';')[0] == productName);

                    if (!productExists)
                    {
                        File.AppendAllText(filepath, joinedString + Environment.NewLine);
                    }
                    else
                    {
                        for(int i = 0; i<lines.Length; i++)
                        {
                            if (lines[i].Split(';')[0] == productName)
                            {
                                lines[i] = joinedString;
                                break;
                            }
                        }

                        File.WriteAllLines(filepath, lines);
                    }
                }

                MessageBox.Show("Product added to cart");
                Thread.Sleep(2000);

                var form2 = new frmMainMenu(email);
                this.Hide();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
                clickable = false;
            }
        }

        // fix the price when you change the amount of items you want to add
        private void updatePrice(object sender, EventArgs e)
        {
            totalPrice = pc.prijs * (double)numAmount.Value;
            lblTotalPrice2.Text = $"€ {totalPrice.ToString()}";
        }
    }
}
