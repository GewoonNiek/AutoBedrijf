using System;
using System.Windows.Forms;

namespace AutoBedrijf
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();

            // Make the password textboxes use the password character instead of plain text
            tbPassword.UseSystemPasswordChar = true;
            tbConfirmPassword.UseSystemPasswordChar = true;
        }
        // Make a database object
        database db = new database();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Call the registerUser function from database class
            db.registerUser(tbName.Text, tbEmail.Text, tbPassword.Text, tbConfirmPassword.Text, tbAddress.Text);
            
            // Open login form
            this.Hide();
            var form2 = new frmLogin();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        // Function to get back to login menu
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Open login form
            this.Hide();
            var form2 = new frmLogin();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
