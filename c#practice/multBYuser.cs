//Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
using System;
class Program
{
	public static void Main()
	{
	int a,b,c;
	Console.WriteLine("Input the First Number:");
	a=int.Parse(Console.ReadLine());
	Console.WriteLine("Input the Second Number:");
	b=int.Parse(Console.ReadLine());
	Console.WriteLine("Input the Third Number:");
	c=int.Parse(Console.ReadLine());
	int e=a*b*c;
	Console.WriteLine(a+"x"+b+"x"+c+"="+e);
	}
}