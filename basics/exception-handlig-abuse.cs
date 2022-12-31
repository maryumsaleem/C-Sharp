using System;
class Program
{
	public static void Main(string[] args)
	{
		try
		{
		Console.WriteLine("Enter Numerator:");
		int numerator=Convert.ToInt32(Console.ReadL());
		Console.WriteLine("Enter Deneminator:");
		int denominator=Convert.ToInt32(Console.Readline());
		
		int result=numerator/denominator;
		
		Console.WriteLine("Result={0}",Result);
		}
		catch(FormatException)
		{
		Console.WriteLine("Please Enter a Number.");	
		}
	}
}