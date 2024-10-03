using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBedrijf
{
    public partial class frmProduct : Form
    {
        string email;
        string productName;
        ProductClass pc;
        database db = new database();

        bool clickable = true;

        public frmProduct(string productName, string email)
        {
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            var form2 = new frmMainMenu(email);
            this.Hide();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (clickable)
            {
                MessageBox.Show("Product added to cart");
                Thread.Sleep(2000);

                var form2 = new frmMainMenu(email);
                this.Hide();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
                clickable = false;
            }
        }
    }
}
