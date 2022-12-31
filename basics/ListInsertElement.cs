using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		var numbers = new List<int>(){ 10, 20, 30, 40 };

		numbers.Insert(1, 11);// inserts 11 at 1st index: after 10.
		
		foreach (var num in numbers)
			Console.WriteLine(num);
	}
}