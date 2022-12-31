using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		var numbers = new List<int>(){ 10, 20, 30, 40, 10 };

		numbers.Remove(10); // removes 10 elements from a list
		
		numbers.RemoveAt(2); //removes the 3rd element (index starts from 0)
		
		//numbers.RemoveAt(10); //removes the 3rd element (index starts from 0)

		foreach (var num in numbers)
			Console.WriteLine(num);
	}
}