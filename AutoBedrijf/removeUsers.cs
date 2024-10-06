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
    public partial class frmRemoveUsers : Form
    {
        userDatabase udb = new userDatabase();
        string email;

        public frmRemoveUsers(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void frmRemoveUsers_Load(object sender, EventArgs e)
        {
            List<User> users = udb.getUsersWithoutAdmin();
            foreach (User u in users)
            {
                placeUsercontrol(new ucRemoveUser(u.email, this, pnlUserlist));
            }
        }

        private void placeUsercontrol(UserControl us)
        {
            us.Dock = DockStyle.Top;
            pnlUserlist.Controls.Add(us);
            us.BringToFront();
        }

        public void loadUsers()
        {
            List<User> users = udb.getUsersWithoutAdmin();
            foreach (User u in users)
            {
                placeUsercontrol(new ucRemoveUser(u.email, this, pnlUserlist));
            }
        }
    }
}
