using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AutoBedrijf
{
    public partial class frmShoppingCart : Form
    {
        string filepath = "./shoppingcart/shoppingcart.txt";
        string email;
        Orderdatabase odb = new Orderdatabase();
        userDatabase udb = new userDatabase();
        pdf pdf = new pdf();

        public frmShoppingCart(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        //Load items into shoppingcart
        private void loadItems(UserControl us)
        {
            us.Dock = DockStyle.Top;
            pnlCartItems.Controls.Add(us);
            us.BringToFront();
        }

        // Load items from file into usercontrols
        private void frmShoppingCart_Load(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines(filepath);

            foreach (var line in lines)
            {
                string[] splittedLine = line.Split(';');
                loadItems(new ucCartItem(splittedLine[0], splittedLine[2], splittedLine[1], this, pnlCartItems));
            }
        }

        // Same thing as above
        public void loadItems()
        {
            var lines = File.ReadAllLines(filepath);

            foreach (var line in lines)
            {
                string[] splittedLine = line.Split(';');
                loadItems(new ucCartItem(splittedLine[0], splittedLine[2], splittedLine[1], this, pnlCartItems));
            }
        }

        // Return to main menu
        private void btnReturn_Click(object sender, EventArgs e)
        {
            var form2 = new frmMainMenu(email);
            this.Hide();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        // Confirm order and return to main menu
        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            odb.AddOrderToDB(email, this);
        }
    }
}
