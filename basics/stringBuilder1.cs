using System;
using System.Text;
					
public class Program
{
	public static void Main()
	{
		//Use the Insert() method inserts a string at the specified index in the StringBuilder object.
		StringBuilder sb = new StringBuilder("Hello World!!",50);
		sb.Insert(5," C#");
		Console.WriteLine(sb);
		
		//Use the Remove() method to remove a string from the specified index and up to the specified length.
		sb.Remove(6, 7);
		Console.WriteLine(sb);
		
		//Use the Replace() method to replace all the specified string occurrences with the specified replacement string.
		StringBuilder sb1 = new StringBuilder("Hello World!!",50);
		sb1.Replace("World", "C#");
		Console.WriteLine(sb1);
	}
}