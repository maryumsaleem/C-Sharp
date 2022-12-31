using System;
using sc = System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassStructureAccessSpecifiersnew;

namespace ClassStructureAccessSpecifiers
{
    class Program
    {
        public int ab;
        static void Main(string[] args)
        {
            MyHome h = new MyHome();
            MyCustomClass m = new MyCustomClass();
            nameSpaceNew.MyNewHome nh = new nameSpaceNew.MyNewHome();
            sc.WriteLine(nh.pencil(3, 6));
            sc.WriteLine(m.Multiply(7));
            sc.ReadKey();
        }


    }
    public class MyCustomClass
    {
        // Class members:
        // Property.
        public int Number { get; set; }

        // Instance Constructor.
        public MyCustomClass()
        {
            Number = 2;
        }

        // Method.
        public int Multiply(int num)
        {
            return num * Number;
        }
    }


    namespace nameSpaceNew
    {
        public class MyNewHome
        {
            public float pencil(int a, int b)
            {


                float c = (float)(a + b) / 2;
                return c;
                //Console.WriteLine(c);
            }
        }
    }

}


namespace ClassStructureAccessSpecifiersnew
{
    public class MyHome
    {
        public float pen(int a, int b)
        {
            float c = (float)(a + b) / 2;
            //MyCustomClass m2 = new MyCustomClass();
            //int d = (int)c;
            //return m2.Multiply(d); 
            return c;
            //Console.WriteLine(c);
        }
    }
}