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
    public partial class frmUserSettings : Form
    {
        string email;
        User us;
        userDatabase db = new userDatabase();

        public frmUserSettings(string email)
        {
            // Get all user information
            InitializeComponent();
            this.email = email;
            us = db.getUserInfo(email);
        }

        private void frmUserSettings_Load(object sender, EventArgs e)
        {
            // Fill in all textboxes, and make sure password isnt visible
            tbUsername.Text = us.name;
            tbEmail.Text = us.email;
            tbAddress.Text = us.address;
            tbPassword.UseSystemPasswordChar = true;
            tbConfirmPassword.UseSystemPasswordChar = true;
        }

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            // check if all fields are filled in, if so update user
            if (tbUsername.Text != null && tbAddress.Text != null & tbEmail.Text != null && tbPassword.Text != null && tbConfirmPassword.Text != null && tbPassword.Text == tbConfirmPassword.Text)
            {
                db.ChangeUser(us.id, tbUsername.Text, tbEmail.Text, tbPassword.Text, us.salt, tbAddress.Text);

                Thread.Sleep(2000); 
                var form2 = new frmMainMenu(tbEmail.Text);
                this.Hide();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
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
