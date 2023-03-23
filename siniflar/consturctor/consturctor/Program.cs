using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consturctor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1_ = new Class1();//ctor1
            Class2 class2_ = new Class2("noname", 21, 10000);//ctor2
            string name;
            int age;
            int salary;
            name = Console.ReadLine();
            age=Convert.ToInt32(Console.ReadLine());
            salary = Convert.ToInt32(Console.ReadLine());
            Class3 class3_ = new Class3(name, age, salary);//constructor3
            
            Console.ReadKey();


        }

    }
}
