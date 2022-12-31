using System;
using System.IO;
public class Program
{
	public static void Main(string[] args)
	{
		try
		{
			StreamReader obj=new StreamReader(@"C:\\c#\\Data.txt");
			Console.WriteLine(obj.ReadToEnd());
			obj.Close();
		}
		catch(Exception ex)
		{
			Console.WriteLine(ex.Message);
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine(ex.StackTrace);
		}
	}
}