using System;
namespace app{
	public class program{
		static void Main(){
			int[] array=new int[5];
			int i;
			for(i=0;i<array.Length;i++){
				array[i]=int.Parse(Console.ReadLine());
			}
			for(i=0;i<array.Length;i++){
				Array.Sort(array);
				Console.WriteLine(array[i]);
			}
		}
	}
}
/*
using System;
using sc = System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using ClassStructureAccessSpecifiersnew;

/*
 Namespaces in C# are used to organize too many classes
 * so that it can be easy to handle the application. 
 * In a simple C# program, we use System.Console 
 * where System is the namespace and Console is the class.
 */
//ist namepspace with one class with main func and another class
/*namespace ClassStructureAccessSpecifiers
{
    class Program
    {
        public int ab;
        static void Main(string[] args)
        {

        }
    }
    public class MyCustomClass {
        //class members
        //properties
        public int Number { get; set;}

        public MyCustomClass() {
            Number = 2;
        }
        //method
        public int multiply(int num) {
            return num * Number;
        }
    }
}
//2nd namespace
namespace namespacenew 
{
    public class myNewHome 
    {

    }
}
*/