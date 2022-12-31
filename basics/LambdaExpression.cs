using System;
namespace testLambda
{
	class Program
	{
		delegate int addition(int a);
		
		static void Main(string[] args)
		{
			addition justAdd=(n)=>n+2;
			//Console.WriteLine(justAdd(33)); can be run also
			int ac=0;
			while(ac<=10)
			{
				Console.WriteLine(ac+" ");
				ac=justAdd(ac);
			}
			/*addition justAdd2 = (n) =>
			{
				int c=n+1;
				int d=c+1; this piece if code is called lambda statement
				return d;
			}
			int ac2=0;
			while ac2=0;
			while (ac2<=10)
			{
				Console.WriteLine(ac2 + " ");
				ac2 = justAdd(ac2);
			}*/
			Console.ReadKey();
		}
	}
}

//single line of code is called lambda expression and multiple line of code is called lambda statement