using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBedrijf
{
    public partial class ucCartItem : UserControl
    {
        string productName;
        string productAmount;
        string productPrice;
        string filepath = "./shoppingcart/shoppingcart.txt";
        frmShoppingCart f;
        FlowLayoutPanel pnl;

        public ucCartItem(string productName, string productAmount, string productPrice, frmShoppingCart f, FlowLayoutPanel pnl)
        {
            InitializeComponent();
            this.productName = productName;
            this.productAmount = productAmount;
            this.productPrice = productPrice;
            this.f = f;
            this.pnl = pnl;
            loadFields();
        }

        public void loadFields()
        {
            lblAmount.Text = productAmount;
            lblPrice.Text = productPrice;
            lblName.Text = productName;
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines(filepath).ToList();

            for (int i = 0; i < lines.Count; i++)
            {
                string[] splittedline = lines[i].Split(';');
                if (splittedline[0] == productName)
                {
                    lines.RemoveAt(i);
                    File.WriteAllLines(filepath, lines);
                    pnl.Controls.Clear();
                }
            }
            f.loadItems();
        }
    }
}
