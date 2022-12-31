using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name=Console.ReadLine();
            Console.WriteLine($"{name} welcome to c# programming");
            //sbyte= signed byte, TypeName=System.Sbyte, Type=signed integer,Size=8bits, Range=-128 to 127
            Console.WriteLine($"sbyte min value={sbyte.MinValue},sbyte max value={sbyte.MaxValue}");

            //short  TypeName=System.Int16, Type=signed integer,Size=16bits, Range=-32768 to 32767
            Console.WriteLine($"short min value={short.MinValue:N0},short max value={short.MaxValue:N0}");

            //int   TypeName=System.Int32, Type=signed integer,Size=32bits, Range=-2^31 to 2^31-1
            Console.WriteLine($"int min value={int.MinValue:N0},int max value={int.MaxValue:N0}");

            //long   TypeName=System.Int64, Type=signed integer,Size=64bits, Range=-2^63 to 2^63-1
            Console.WriteLine($"long min value={long.MinValue:N0},long max value={long.MaxValue:N0}");

            //byte   TypeName=System.byte, Type=Unsigned integer,Size=8bits, Range=0 to 255
            Console.WriteLine($"byte min value={byte.MinValue},byte max value={byte.MaxValue}");

            //ushort  TypeName=System.UInt16, Type=Unsigned integer,Size=16bits, Range=0 to 65535
            Console.WriteLine($"ushort min value={ushort.MinValue:N0},ushort max value={ushort.MaxValue:N0}");


            //uint  TypeName=System.UInt23, Type=Unsigned integer,Size=32bits, Range=0 to 2^32
            Console.WriteLine($"uint min value={uint.MinValue:N0},uint max value={uint.MaxValue:N0}");


            //ulong  TypeName=System.UInt64, Type=Unsigned integer,Size=64bits, Range=0 to 2^63
            Console.WriteLine($"ulong min value={ulong.MinValue:N0},ulong max value={ulong.MaxValue:N0}");


            //float  TypeName=System.Single,Size=32bits, Range=±1.5 × 10^-45 to ±3.4 × 10^38
            Console.WriteLine($"float min value={float.MinValue:N0},float max value={float.MaxValue:N0}");

            //double  TypeName=System.Double,Size=64bits, Range=±5.0 × 10^-324 to ±1.7 × 10^308
            Console.WriteLine($"double min value={double.MinValue:N0},double max value={double.MaxValue:N0}");

            //decimal  TypeName=System.Decimal,Size=128bits, Range=±1.0 × 10^-28 to ±7.9228 × 10^28
            Console.WriteLine($"decimal min value={decimal.MinValue:N0},decimal max value={decimal.MaxValue:N0}");

            //char  ,Size=2bytes, Range=U +0000 to U +ffff,unicode based
            Console.WriteLine($"char min value={char.MinValue:N0},char max value={char.MaxValue:N0}");

            //DateTime 
            Console.WriteLine($"DateTime min value={DateTime.MinValue},DateTime max value={DateTime.MaxValue}");

            //casting and convertion
            //smalller to bigger implicit casting
            //Numeric to Numeric
            int i = 10;
            double r = i;//implicit casting
            int ii =(int) r;//explicit casting

            //String to Numeric
            // string is a reference type
            string s = "123";
            int aa = Convert.ToInt32 (s);//String to Numeric
            string s1 = Convert.ToString(aa);
            Console.WriteLine(aa);

            //object reference type on heap
            int k = 123;
			//What is boxing?
            object o = k;//boxing:Boxing is the process of converrting a value type to the type object.
            k = 2000;// Change the value of k
            Console.WriteLine($"Value type of k is {k}");
            Console.WriteLine($"Object type k is {o}");

            int j = Convert.ToInt32(o);//unboxing
            Console.WriteLine($"unboxing {j}");
			
			//how BOXING works?
			/*
			boxing and unboxing are specially used to treat
			value type objects as reference type, moving their actuall value to the managed heap
            and accessing their value by reference. without boxing nd unboxing you could never
            pass value-types by reference, and that means you could not pass value-types as instance of object.*/	
            //why we use BOXING?			
			/*
			boxing and unboxing enables a unified view of the type system where in a value
			of any type can ultimately be treated as an object.
			/*
			Boxing and unboxing 
			*/
			//another example of boxing and unboxing
			double e=2.476589;
			double d=e;
			object o1=d;
			object o2=e;
			Console.WriteLine(d==e);//it will return true.
			Console.WriteLine(o1==o2);//it will compare reference(memory address) so it will print false.
			
            //var it detectes at compile time
            // Creating and initializing
            // implicitly typed variables
            // Using var keyword
            var a = 'f';
            var b = "GeeksforGeeks";
            var c = 30.67d;
            var d = false;
            var e = 54544;

            // Display the type
            Console.WriteLine("---------var--------- \nType of 'a' is : {0} ", a.GetType());

            Console.WriteLine("Type of 'b' is : {0} ", b.GetType());

            Console.WriteLine("Type of 'c' is : {0} ", c.GetType());

            Console.WriteLine("Type of 'd' is : {0} ", d.GetType());

            Console.WriteLine("Type of 'e' is : {0} ", e.GetType());

            //dynamic it detects at run time
            // Dynamic variables
            dynamic val1 = "GeeksforGeeks";
            dynamic val2 = 3234;
            dynamic val3 = 32.55;
            dynamic val4 = true;

            // Get the actual type of
            // dynamic variables
            // Using GetType() method
            Console.WriteLine("---------dynamic---------\nGet the actual type of val1: {0}",
                                      val1.GetType().ToString());

            Console.WriteLine("Get the actual type of val2: {0}",
                                      val2.GetType().ToString());

            Console.WriteLine("Get the actual type of val3: {0}",
                                      val3.GetType().ToString());

            Console.WriteLine("Get the actual type of val4: {0}",
                                      val4.GetType().ToString());

        }
    }
}
