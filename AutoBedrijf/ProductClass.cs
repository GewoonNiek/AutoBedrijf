using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBedrijf
{ 
    internal class ProductClass
    {
        public string merk { get; set; }
        public int bouwjaar { get; set; }
        public string tellerstand { get; set; }
        public double prijs { get; set; }
        public int amount { get; set; }
        public Image picture { get; set; }

        public ProductClass()
        {

        }
    }
}
