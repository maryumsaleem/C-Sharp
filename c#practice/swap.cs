//Write a C# Sharp program to swap two numbers
using System;
class Program
{
	public static void Main(string[] args)
	{
		int a,b,temp;
		Console.WriteLine("Enter First Number:");
		a=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter Second Number:");
		b=int.Parse(Console.ReadLine());
		temp=a;
		a=b;
		b=temp;
		Console.WriteLine("After Swapping");
		Console.WriteLine("First Number {0}",a);
		Console.WriteLine("Second Number {0}",b);
		Console.ReadKey();
	}
}