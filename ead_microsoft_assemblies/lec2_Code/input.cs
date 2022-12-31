 using System;

namespace HelloWorld
{

public class Input
{
	public static void Main(string[] args)
	{
	    string number; 
		int num;
		Console.WriteLine("enter number: ");
		number= Console.ReadLine();
		num=Convert.ToInt32(number);
		Console.WriteLine(num);
		
	}
}
}