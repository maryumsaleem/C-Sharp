using System;
namespace App
{
	class Program{
		static void Main(string[] args)
		{
		MyApp.Person myObj=new MyApp.Person();
		myObj.Name="Liam";
		Console.WriteLine(myObj.Name);
	}
	}
}



namespace MyApp
{
	class Person{
		private string name;//field
		public string Name
		{
			get{return name;}
			set{name=value;}
		}
	}
}