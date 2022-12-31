using System;
					
public class Program
{
	public static void Main()
	{
		Predicate<string> isUpper = IsUpperCase;

		bool result = isUpper("hello world!!");
	
		Console.WriteLine(result);
	}
	
	public static bool IsUpperCase(string str)
	{
		return str.Equals(str.ToUpper());
	}

}
/*Points to Remember:
Predicate delegate takes one input parameter and boolean return type.
Anonymous method and Lambda expression can be assigned to the predicate delegate.