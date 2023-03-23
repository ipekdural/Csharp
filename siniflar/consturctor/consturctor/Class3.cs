using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consturctor
{
    internal class Class3
    {
        private string name;
        private int age;
        private int salary;
        public Class3(string _name,int _age,int _salary)
        {
            name = _name;
            age = _age; 
            salary = _salary;
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(salary);
        }
    }
}
