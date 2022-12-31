using System;
class Program
{
	public static void Main(string[] args)
	{
		try
		{
		Console.WriteLine("Enter Numerator:");
		int numerator=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Deneminator:");
		int denominator=Convert.ToInt32(Console.ReadLine());
		
		int result=numerator/denominator;
		
		Console.WriteLine("Result={0}",result);
		}
		
		catch(FormatException)
		{
		Console.WriteLine("Please Enter a Number.");	
		}
		catch(OverflowException)
		{
		Console.WriteLine("Only Number between {0} and {1} are allowed.",Int32.MinValue,Int32.MaxValue);	
		}
		catch(DivideByZeroException)
		{
		Console.WriteLine("Denominator Cannot be Zero.");	
		}
		catch(Exception ex)
		{
		Console.WriteLine(ex.Message);	
		}
	}
}