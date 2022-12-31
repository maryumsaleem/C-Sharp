using System;
namespace app
{
	public class Car
	{
		string color="red";
		static void Main(string[] args)
		{
			Car myobj=new Car();
			Console.WriteLine(myobj.color);
		}
	}
}