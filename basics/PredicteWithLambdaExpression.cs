using System;
					
public class Program
{
	public static void Main()
	{
		Predicate<string> isUpper = s => s.Equals(s.ToUpper());
    	bool result = isUpper("hello world!!");
		
		Console.Write(result);
	}
}