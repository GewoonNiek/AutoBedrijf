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
    public partial class frmInvoices : Form
    {
        string email;
        Orderdatabase odb = new Orderdatabase();
        userDatabase udb = new userDatabase();
        public frmInvoices(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void frmInvoices_Load(object sender, EventArgs e)
        {
            loadInvoices();
        }
        public void loadInvoices()
        {
            int userID = udb.getUserID(email);
            List<Order> orders = odb.getAllOrdersByID(userID);
            foreach (Order o in orders)
            {
                getUsercontrol(new ucInvoice(o.orderid, o.totalPrice, this, email));
            }
        }

        public void getUsercontrol(UserControl us)
        {
            us.Dock = DockStyle.Top;
            pnlInvoiceList.Controls.Add(us);
            us.BringToFront();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            var form2 = new frmMainMenu(email);
            this.Hide();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
