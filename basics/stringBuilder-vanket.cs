//string builder is muttable and comes in system.Text class
using System;
using System.Text;
public class Program
{
	public static void Main(string[] args)
	{
		StringBuilder userStringBuilder=new StringBuilder("C#");
		userStringBuilder.Append(" video");
		userStringBuilder.Append(" Tutorial");
		userStringBuilder.Append(" for");
		userStringBuilder.Append(" Beginners");
		Console.WriteLine(userStringBuilder.ToString());
	}
}