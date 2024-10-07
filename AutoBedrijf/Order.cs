using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBedrijf
{
    internal class Order
    {
        public int orderid { get; set; }
        public int userid { get; set; }
        public string productstring { get; set; }
        public string totalPrice { get; set; }
        public string amountString { get; set; }

        public Order() { }
    }
}
