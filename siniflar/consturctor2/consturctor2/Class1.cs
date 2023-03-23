using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consturctor2
{
    internal class Class1
    {
        private string name;
        private int age;
        private int salary;
        public string NAME
        {
            get { return name; }
            set { name = value.ToUpper(); }
        }
        public int AGE
        {
            get { return age; }
            set { age = Convert.ToInt32(value); }
        }
        public int SALARY
        {
            get { return salary; }
            set { salary = Convert.ToInt32(value); }
        }
        public Class1()
        {
            
            name="noname";
            age= 0;
            salary= 0;
            
            
        }

    }
}
