using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		IList <int> intList1 = new List<int>();
		intList1.Add(10);
		intList1.Add(20);
		intList1.Add(30);
		intList1.Add(40);
		
		List<int> intList2 = new List<int>();
		
		intList2.AddRange(intList1);


		Console.WriteLine(intList2.Count);
		
	}
}

