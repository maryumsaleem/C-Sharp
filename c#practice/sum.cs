//21. Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.
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
		Console.WriteLine(result(num1,num2));
		
	}
	public static bool result(int a,int b)
	{
		if(a==20||b==20||a+b==20)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
}