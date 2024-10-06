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
    public partial class ucRemoveUser : UserControl
    {
        string email;
        frmRemoveUsers f;
        userDatabase udb = new userDatabase();
        FlowLayoutPanel pnl;
        public ucRemoveUser(string email, frmRemoveUsers f, FlowLayoutPanel pnl)
        {
            InitializeComponent();
            this.email = email;
            this.f = f;
            this.pnl = pnl;
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            udb.deleteUser(email);
            
            pnl.Controls.Clear();
            f.loadUsers();
        }

        private void ucRemoveUser_Load(object sender, EventArgs e)
        {
            lblUsername.Text = udb.getUsername(email);
        }
    }
}
