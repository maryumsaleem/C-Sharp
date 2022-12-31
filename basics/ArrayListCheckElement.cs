using System;
using System.Collections;
					
public class Program
{
	public static void Main()
	{
		ArrayList arList = new ArrayList()
                {
                    1,
                    "Bill",
                    300,
                    4.5f,
                    300
                };

		Console.WriteLine(arList.Contains(300)); // true
		Console.WriteLine(arList.Contains("Bill")); // true
		Console.WriteLine(arList.Contains(10)); // false
		Console.WriteLine(arList.Contains("Steve")); // false
	}
}