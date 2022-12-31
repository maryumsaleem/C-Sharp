//inner exception is a property of exception class just like message and stackTrace.
//The inner exception property returns the exception instance that caused the current exception.
//To retain the original exception pass it to the parameter of cunstructoe,of the current exception.
//Always check if inner exception is not null before accessing any property of the inner exception object,else, you may get Null Reference Exception.
//To get the type of InnerException use GetType() method.
using System;
using System.IO;
public class Program
{
	public static void Main(string[] args)
	{
		try
		{
		try
		{
			Console.WriteLine("Enter First Number:");
			int FN=Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Enter Second Number");
			int SN=Convert.ToInt32(Console.ReadLine());
			
			int Result;
			Result=FN/SN;
			Console.WriteLine("Result={0}",Result);
		}
		catch(Exception ex)
		{
			string filePath=@"C:\c#\log.txt";
			if(File.Exists(filePath))
			{
				StreamWriter sw=new StreamWriter(filePath);
				sw.WriteLine(ex.GetType().Name);
				sw.Write(ex.Message);
				sw.Close();
				Console.WriteLine("There is a problem,please try later");
			}
			else
			{
				throw new FileNotFoundException(filePath+"is not present");
			}
		}
		}
		
			catch(Exception ex)
	{
	Console.WriteLine("Current Exception={0}",ex.GetType().Name);
    Console.WriteLine("Inner Exception={0}",ex.InnerException.GetType().Name);	
	}
	}

}