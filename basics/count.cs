using System;
using System.Linq;

public class Program
{
	public static void Main()
	{
		string[] empty = new string[5];
		var totalElements = empty.Count();
		Console.WriteLine(totalElements);
		
		string[] animals = {"Cat", "Alligator", "fox", "donkey", "Cat", "alligator"};
		totalElements = animals.Count();
		Console.WriteLine(totalElements);
		
		int[] nums = {1, 2, 3, 4, 3, 55, 23, 2, 5, 6, 2, 2};
		totalElements = nums.Count();
		Console.WriteLine(totalElements);
	}
}