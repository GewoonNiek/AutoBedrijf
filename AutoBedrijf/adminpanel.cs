using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AutoBedrijf
{
    public partial class frmAdminPanel : Form
    {
        string email;

        public frmAdminPanel(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        // go to adjust inventory form
        private void pbInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmInventory(email);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        // go to remove users form
        private void pbRemoveUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmRemoveUsers(email);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
