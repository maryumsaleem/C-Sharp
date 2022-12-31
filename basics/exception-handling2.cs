using System;
using System.IO;
public class Program
{
	public static void Main(string[] args)
	{
		StreamReader obj=null;
		try
		{
		    obj=new StreamReader(@"C:\\c#\\Data2.txt");
			Console.WriteLine(obj.ReadToEnd());
		}
		
		catch(FileNotFoundException ex)
		{
          Console.WriteLine("Please check if the file {0} existis",ex.FileName);
		}
		
		catch(Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		
		finally
		{
			if(obj!=null)
			{
				obj.Close();
			}
			Console.WriteLine("Finally Block");
		}
	}
}