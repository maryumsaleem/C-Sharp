using System;
using System.Linq;
public class Program
{
	public static void Main(string[] args)
	{
		int[] nums=new int[5]{10, 15, 16, 8, 6};
		//Linq Methods
		Console.WriteLine("Max="+nums.Max());
		Console.WriteLine("Min="+nums.Min());
		Console.WriteLine("Sum="+nums.Sum());
		Console.WriteLine("Avg="+nums.Average());
		//Array Methods
		Console.WriteLine("Orignal Array");
		foreach(var i in nums)
		{
			Console.WriteLine(i);
		}
		Array.Sort(nums);
		Console.WriteLine("Sorted Array");
		foreach(var i in nums)
		{
			Console.WriteLine(i);
		}
		Array.Reverse(nums);
		Console.WriteLine("Reversed Array");
		foreach(int i in nums)
		{
			Console.WriteLine(i);
		}
		Console.WriteLine("Binary Search");
		Console.WriteLine(Array.BinarySearch(nums, 15));
		
		//Passing Array as Argument
		Console.WriteLine("Array as argument nd plus 10");
		UpdateArray(nums);
		foreach (var item in nums)
		{
			Console.WriteLine(item);
		}
	}
	
	public static void UpdateArray(int[] arr)
	{
		for (int i = 0; i < arr.Length; i++)
			arr[i] = arr[i] + 10;
	}
}

/*LINQ Methods
All the arrays in C# are derived from an abstract base class System.Array.

The Array class implements the IEnumerable interface, so you can LINQ extension methods such as Max(), Min(), Sum(), reverse(), etc. See the list of all extension methods here.*/

/*
The System.Array class also includes methods for creating, manipulating, searching, and sorting arrays. See list of all Array methods 
*/