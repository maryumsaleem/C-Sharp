using System;

public class Program
{
	public static void Main()
	{
		char[] chars = {'H', 'e', 'l', 'l', 'o'};
		
		string str1 = new string (chars);
		string str2 = new string(chars);
		
		foreach (char c in str1)
		{
			Console.WriteLine(c);
		}
	}
}