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
    public partial class frmChangeAmount : Form
    {
        Image photo;
        string email;
        productDatabase db = new productDatabase();
        string productName;
        public frmChangeAmount(string email, Image photo, string productName)
        {
            InitializeComponent();
            this.email = email; 
            this.photo = photo;
            this.productName = productName;
        }

        private void ChangeAmount_Load(object sender, EventArgs e)
        {
            pbProductPhoto.Image = photo;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int oldInventory = db.getInventory(productName);

            int newInventory = (int)numAmount.Value + oldInventory;

            db.updateInventory(newInventory, productName);

            this.Hide();
            var form2 = new frmMainMenu(email);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
