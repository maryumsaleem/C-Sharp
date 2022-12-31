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
            object o = a; // Boxing : Boxing is the process of converting a value type to the type object
            a = 786;
            int c = (int)o; // Unboxing

            Console.WriteLine("Value of a is " + a);
            
            Console.WriteLine("Value of O is " + o + " , C is "+c);

            /*
             Boxing and Unboxing are specifically used to treat
             * value-type objects as reference-type; moving their 
             * actual value to the managed heap and accessing their
             * value by reference. Without boxing and unboxing you 
             * could never pass value-types by reference; and that 
             * means you could not pass value-types as instances of Object.
             */

            /*
             Boxing and unboxing enables a unified view of the type system
             * wherein a value of any type can ultimately be treated as an object.
             */
            double e = 2.718281828459045;
            double d = e;
            object o1 = d;
            object o2 = e;
            Console.WriteLine(d == e);
            Console.WriteLine(o1 == o2);
            

            Console.ReadKey();
        }
    }
}
