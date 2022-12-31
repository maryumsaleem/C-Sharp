using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{		
		List<int> intList = new List<int>() { 10, 20, 30, 40, 50 };
Console.WriteLine("First way of accesing list");
		intList.ForEach(el => Console.WriteLine(el));

Console.WriteLine("second way of accesing list");
		foreach (var el in intList)
        	Console.WriteLine(el);
		
		Console.WriteLine("Third way of accesing list");
		for(int i =0; i < intList.Count; i++)
			Console.WriteLine(intList[i]);
		
	}
}
