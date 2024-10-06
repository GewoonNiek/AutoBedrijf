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
    public partial class frmAddProduct : Form
    {
        string email;
        public frmAddProduct(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        productDatabase pdb = new productDatabase();

        // Select a png for the product
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbProductImage.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        // Add product to database when all fields are filled in
        private void btnConfirm_Click(object sender, EventArgs e)
        {
           if (pbProductImage.Image != null && tbKilometers.Text != null && tbPrice.Text != null && tbType.Text != null && tbYear.Text != null && numAmount.Value != 0)
           {
                pdb.addProductToDB(pbProductImage.Image, tbKilometers.Text, tbPrice.Text, tbType.Text, tbYear.Text, numAmount.Value, this, email);
           }
        }

        // return to main menu
        private void btnReturn_Click(object sender, EventArgs e)
        {
            var form2 = new frmMainMenu(email);
            this.Hide();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
