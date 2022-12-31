using System;

public class Program
{
	public static void Main()
	{
		
		string text = "This is a \"string\" in C#.";
		string str = "xyzdef\\rabc";
		string path = "\\\\mypc\\ shared\\project";
		
		Console.WriteLine(text);
		Console.WriteLine(str);
		Console.WriteLine(path);
		
		//verbatim strings
		string str = @"xyzdef\rabc";
		string path = @"\\mypc\shared\project";
		string email = @"test@test.com";
		
		Console.WriteLine(str);
		Console.WriteLine(path);
		Console.WriteLine(email);
	}
}