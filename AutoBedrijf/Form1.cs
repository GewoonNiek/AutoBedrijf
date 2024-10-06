using System;
using System.Windows.Forms;

namespace AutoBedrijf
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            // Make password textbox use the password character instead of plain text
            tbPassword.UseSystemPasswordChar = true;
        }

        // Make a database object
        userDatabase db = new userDatabase();

        // function to login the user
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Call login function from database class
            db.loginUser(tbEmail.Text, tbPassword.Text, this);
        }

        // Function to open register menu
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Open register form
            this.Hide();
            var form2 = new frmRegister();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
