using System;

public class Program
{
	public static void Main()
	{
		for (int i = 0, j = 0; i + j < 5; i++, j++)
		{
			Console.WriteLine("Value of i: {0}, J: {1} ", i, j);
		}
	}
}