using System;
using System.Linq;

public class Program
{
	public static void Main()
	{
		string[] animals = {"Cat", "Alligator", "fox", "donkey", "Cat", "alligator"};
		var totalCats = animals.Count(s => s == "Cat");
		Console.WriteLine(totalCats);
		
		var animalsStartsWithA = animals.Count(s => s.StartsWith("a", StringComparison.CurrentCultureIgnoreCase));
		Console.WriteLine(animalsStartsWithA);
		
		int[] nums = {1, 2, 3, 4, 3, 55, 23, 2, 5, 6, 2, 2};
		var totalEvenNums = nums.Count(n => n % 2 == 0);
		Console.WriteLine(totalEvenNums);
	}
}