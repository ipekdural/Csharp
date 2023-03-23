using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsulleme
{
    internal class araba
    {
        public int km;
        private int age;
        private string brand;

        public int Age
        {
            get { return age; }
            set { age = Math.Abs(value); }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value.ToUpper(); }
        }
    }
}
