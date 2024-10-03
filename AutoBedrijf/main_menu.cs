using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBedrijf
{
    public partial class frmMainMenu : Form
    {
        private database db = new database();
        string email;

        public frmMainMenu(string email)
        {
            InitializeComponent();
            checkRole(email);
            this.email = email;

        }

        // Close program
        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            // Open main menu form
            this.Hide();
            var form2 = new frmMainMenu(email);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            // Open login form
            this.Hide();
            var form2 = new frmLogin();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
        
        // Check which role user has, if user has role 1, let adminpanel button be visible, same for addProduct button
        public void checkRole(string email)
        {
            if (db.getRole(email) == 1)
            {
                pbAdminPanel.Visible = true;
                pbAddProduct.Visible = true;
            }
            else
            {
                pbAdminPanel.Visible = false;
                pbAddProduct.Visible = false;
            }
        }

        private void pbAdminPanel_Click(object sender, EventArgs e)
        {
            // Open admin panel form
            this.Hide();
            var form2 = new frmAdminPanel();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void pbShoppingCart_Click(object sender, EventArgs e)
        {
            // Open shoppingcart form
            this.Hide();
            var form2 = new frmShoppingCart();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void pbAddProduct_Click(object sender, EventArgs e)
        {
            // Open add product form
            this.Hide();
            var form2 = new frmAddProduct(email);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        // Load products into panel
        private void loadProducts(UserControl us)
        {
            us.Dock = DockStyle.Top;
            pnlProducts.Controls.Add(us);
            us.BringToFront();
        }

        // Load products into main menu when the form gets loaded
        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            List<ProductClass> products = db.getAllProducts();
            foreach (ProductClass p in products)
            {
                loadProducts(new ucProduct(p.picture, this, p.merk, email));
            }
        }

        // Button to go to the change user settings form
        private void pbUserSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmUserSettings(email);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
