using System;
namespace MyApp
{
	class Program
	{
		static void Main(string[] args)
		{
			App.Prog myObj=new App.Prog();
			myObj.Num=23;
			Console.WriteLine(myObj.Num);
		}
	}
}

namespace App
{
	class Prog
	{
		//private int num;//field
		public int Num
		{get; set;}
		
		
	}
	
}