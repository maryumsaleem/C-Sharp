using System;
class Program
{
	public static void Main(string[] args)
	{
		try
		{
		Console.WriteLine("Enter Numerator:");
		int numerator;
		bool IsNumeratorConversionSuccessful=Int32.TryParse(Console.ReadLine(),out numerator);
		if(IsNumeratorConversionSuccessful)
		{
			Console.WriteLine("Enter Deneminator:");
			int denominator;
			bool IsDenominatorConversionSuccessful=Int32.TryParse(Console.ReadLine(),out denominator);
			
			if(IsDenominatorConversionSuccessful && denominator!=0)
			{
				int Result=numerator/denominator;
				Console.WriteLine("Result={0}",Result);
			}
			else
			{
				if(denominator==0)
				{
					Console.WriteLine("Denominator can not be zero.");
				}
				else
				{
					Console.WriteLine("Deneminator should be a valid number between {0}&&{1} are allowed",Int32.MinValue,Int32.MaxValue);
				}
			}
		}
		       else
				{
					Console.WriteLine("Deneminator should be a valid number between {0}&&{1} are allowed",Int32.MinValue,Int32.MaxValue);
				}
		}
		
		
		catch(Exception ex)
		{
		Console.WriteLine(ex.Message);	
		}
	}
}