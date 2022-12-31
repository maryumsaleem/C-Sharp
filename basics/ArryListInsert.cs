using System;
using System.Collections;
					
public class Program
{
	public static void Main()
	{
		ArrayList arlist = new ArrayList()
                {
                    1,
                    "Bill",
                    300,
                    4.5f
                };

		arlist.Insert(1, "Second Item");

		foreach (var val in arlist)
			Console.WriteLine(val); 
	}
}