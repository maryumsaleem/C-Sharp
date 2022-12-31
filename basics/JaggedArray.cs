using System;
					
public class Program
{
	public static void Main()
	{
		int[][] jArray = new int[2][] // can include two single-dimensional arrays
		{
				new int[3]{1, 2, 3},

                new int[4]{4, 5, 6, 7}
		};
		
		Console.WriteLine(jArray[0][0]);
		Console.WriteLine(jArray[0][1]);
		Console.WriteLine(jArray[0][2]);
		Console.WriteLine(jArray[1][0]);
		Console.WriteLine(jArray[1][1]);
		Console.WriteLine(jArray[1][2]);
		Console.WriteLine(jArray[1][3]);
	}
}