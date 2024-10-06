using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AutoBedrijf
{
    public partial class ucProduct : UserControl
    {
        string email;
        Form f;
        string productName;
        int phase;
        Image photo;

        public ucProduct(Image photo, Form f, string productName, string email, int phase)
        {
            this.phase = phase;
            InitializeComponent();
            pbPicture.Image = photo;
            this.email = email;
            this.f = f;
            this.productName = productName;
            this.photo = photo;

            if (phase == 1)
            {
                btnCheckProduct.Text = "Change this amount";
            }
        }

        // Button to open the product info form
        private void btnCheckProduct_Click(object sender, EventArgs e)
        {
            if(phase != 1)
            {
                var form2 = new frmProduct(productName, email);
                f.Hide();
                form2.Closed += (s, args) => f.Close();
                form2.Show();
            }
            else
            {
                var form2 = new frmChangeAmount(email, photo, productName);
                f.Hide();
                form2.Closed += (s, args) => f.Close();
                form2.Show();
            }
        }
    }
}
