using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = 123;
            object o = a; // Boxing
            a = 786;
            int c = (int)o; // Unboxing

            Console.WriteLine("Value of a is " + a);
            
            Console.WriteLine("Value of O is " + o + " , C is "+c);


            /*
            double e = 2.718281828459045;
            double d = e;
            object o1 = d;
            object o2 = e;
            Console.WriteLine(d == e);
            Console.WriteLine(o1 == o2);
            */

            Console.ReadKey();
        }
    }
}
