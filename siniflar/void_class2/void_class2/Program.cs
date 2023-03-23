using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace void_class2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Get_info person1 = new Get_info();
            Console.Write("please enter your name:");
            string name;
            name=Console.ReadLine();
            Console.Write("please enter your age:");
            int age;
            age =Convert.ToInt32(Console.ReadLine());
            Console.Write("please enter your gender:");
            char gender;
            gender=Convert.ToChar(Console.ReadLine());
            person1.getinfo(name, age, gender);
            Console.Read();
        }
    }
}
