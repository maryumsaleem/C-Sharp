using System;
using System.Collections;

public class Program
{
	public static void Main()
	{
		var arlist = new ArrayList()
                {
                    1,
                    "Bill",
                    300,
                    4.5f
                };

		//Access individual item using indexer
		int firstElement = (int) arlist[0]; //returns 1
		string secondElement = (string) arlist[1]; //returns "Bill"
		//int secondElement = (int) arlist[1]; //Error: cannot cover string to int

		//using var keyword without explicit casting
		var first = arlist[0]; //returns 1
		var second = arlist[1]; //returns "Bill"
		//var fifthElement = arlist[5]; //Error: Index out of range

		//update elements
		arlist[0] = "Steve"; 
		arlist[1] = 100;
		//arlist[5] = 500; //Error: Index out of range
	}
}