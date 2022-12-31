using System;

namespace MyApp1
{
	class Vehicle//Base Class
	{
		public string brand = "Ford";
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
		public string modelName = "Mustang";
	}
}
namespace MyApp
{
	class Program
	{
		static void Main(string[] args)
		{
			//car object
			APP.Car myCar = new APP.Car();
			 myCar.honk();

			Console.WriteLine(myCar.brand + " " + myCar.modelName);
		}
	}
}

/*namespace app
{
	public class program
	{
		static void Main()
		{
			int[] array = new int[5];
			int i;
			for (i = 0; i < array.Length; i++)
			{
				array[i] = int.Parse(Console.ReadLine());
			}
			for (i = 0; i < array.Length; i++)
			{
				Array.Sort(array);
				Console.WriteLine(array[i]);
			}
			Console.ReadKey();
		}
	}
}*/