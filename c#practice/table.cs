//Write a C# Sharp program that takes a number as input and print its multiplication table
using System;
class Program
{
	public static void Main(string[] args)
	{
		int n;
		Console.WriteLine("Enter the output number:");
		n=int.Parse(Console.ReadLine());
		for(int i=0;i<=10;i++)
		{
			Console.WriteLine(n+"x"+i+"="+n*i);
		}
	}
}