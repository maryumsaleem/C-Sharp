//20. Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than second number.
using System;
class Program
{
	public static void Main(string[] args)
	{
		int num1,num2;
		Console.WriteLine("Enter num1:");
		num1=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter num2:");
		num2=int.Parse(Console.ReadLine());
		Console.WriteLine(difference(num1,num2));
		Console.WriteLine(difference(13,40));
		Console.WriteLine(difference(50,21));
		Console.WriteLine(difference(0,23));
	}
	public static int difference(int a,int b)
	{
		if(a>b)
		{
			return (a-b)*2;
		}
		else
		{
			return b-a;
		}
	}
}