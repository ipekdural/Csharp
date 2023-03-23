using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consturctor2//ctor default deger atamasi icin kullanilir.
{
    internal class Program
    {
        static void Main(string[] args)
        {

        Class1 id1 = new Class1();
         
            id1.NAME = "Test";
            Console.WriteLine(id1.NAME);
            id1.AGE = 10;   
            Console.WriteLine(id1.AGE);
            Console.WriteLine(id1.SALARY);
 

            Console.ReadKey();
        }
    }
}
