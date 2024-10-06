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
    public partial class frmInventory : Form
    {
        string email;
        productDatabase db = new productDatabase();
        public frmInventory(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            List<ProductClass> products = db.getAllProducts();
            foreach (ProductClass p in products)
            {
                loadProducts(new ucProduct(p.picture, this, p.merk, email, 1));
            }
        }

        private void loadProducts(UserControl us)
        {
            us.Dock = DockStyle.Top;
            pnlProducts.Controls.Add(us);
            us.BringToFront();
        }
    }
}
