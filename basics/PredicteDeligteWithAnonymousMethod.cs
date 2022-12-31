using System;
					
public class Program
{
	public static void Main()
	{
		Predicate<string> isUpper = delegate(string s) { return s.Equals(s.ToUpper());};
    	bool result = isUpper("hello world!!");
		
		Console.Write(result);
	}
}