using System;
namespace app1
{
	interface IfirstInterface
	{
		void myMethod();//interface method
	}
}
namespace app2
{
	interface IsecInterface
	{
		void secMethod();//interface method
	}
}
namespace app3
{
	class Demo:app1.IfirstInterface,app2.IsecInterface
	{
		public void myMethod()
		{
			Console.WriteLine("FIRST INTERFACE METHOD");
		}
		
		public void secMethod()
		{
			Console.WriteLine("SECOND INTERFACE METHOD");
		}
		
	}
}
namespace app
{
	class main
	{
		static void Main(string[] args)
		{
			app3.Demo myObj=new app3.Demo();
			myObj.myMethod();
			myObj.secMethod();
		}
	}
}