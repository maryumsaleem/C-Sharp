//25. Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.
using System;
class Program
{
	public static void Main(string[] args)
	{
		for(int i=1;i<=100;i++)
		{
			if(i%2==1)
			{
				Console.WriteLine(i);
			}
		}
	}
}