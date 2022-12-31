using System;

namespace MyApp1
{
	sealed class Vehicle//Base Class
	{
		public string brand="Ford";
		public void honk()
		{
			Console.WriteLine("tut, tut");
		}
	}
}
namespace APP
{
  class Car : MyApp1.Vehicle//DERIVED
  {
	  public string modelName="Mustang";
  }
}
namespace MyApp
{
	class Program
	{
		static void Main(string[] args)
		{
			//car object
			APP.Car myCar=new APP.Car();
			 myCar.honk();
			
			Console.WriteLine(myCar.brand + " " + myCar.modelName);
		}
	}
}
