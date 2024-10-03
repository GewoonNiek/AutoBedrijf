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
    public partial class ucProduct : UserControl
    {
        string email;
        Form f;
        string productName;
        public ucProduct(Image photo, Form f, string productName, string email)
        {
            InitializeComponent();
            pbPicture.Image = photo;
            this.email = email;
            this.f = f;
            this.productName = productName;
        }

        private void btnCheckProduct_Click(object sender, EventArgs e)
        {
            var form2 = new frmProduct(productName, email);
            f.Hide();
            form2.Closed += (s, args) => f.Close();
            form2.Show();
        }
    }
}
