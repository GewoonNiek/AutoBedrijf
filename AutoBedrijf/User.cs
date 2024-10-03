using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBedrijf
{
    internal class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string salt { get; set; }

        public User()
        {

        }
    }
}
