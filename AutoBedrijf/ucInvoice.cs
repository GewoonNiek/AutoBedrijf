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
    public partial class ucInvoice : UserControl
    {
        pdf pdf = new pdf();
        userDatabase udb = new userDatabase();
        string email;
        int invoiceID;

        public ucInvoice(int invoiceID, string totalPrice, frmInvoices f, string email)
        {
            InitializeComponent();
            lblInvoiceID.Text = invoiceID.ToString();
            lblTotalPrice.Text = totalPrice;
            this.email = email;
            this.invoiceID = invoiceID;
        }

        private void btnCheckInvoice_Click(object sender, EventArgs e)
        {
            pdf.OpenPDF(invoiceID);
        }
    }
}
