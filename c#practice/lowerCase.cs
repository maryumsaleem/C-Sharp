//Write a C# program to convert a given string into lowercase.
using System;
class Program
{
	public static void Main(string[] args)
	{
	string s;
	Console.WriteLine("Enter String in Upper Case:");
	s=Console.ReadLine();
	
	Console.WriteLine(s.ToLower());
	}
	
}