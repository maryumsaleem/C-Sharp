//C# Sharp Exercises: Program to convert from celsius degrees to Kelvin and Fahrenheit
using System;
class Program
{
	public static void Main(string[] args)
	{
		int celsius;
		Console.WriteLine("Enter the amount of Celcius");
		celsius=int.Parse(Console.ReadLine());
		Console.WriteLine("Kelvin={0}",celsius+273);
		Console.WriteLine("Fahrenheit={0}",celsius*18/10+32);
	}
}