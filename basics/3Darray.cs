using System;

public class Program
{
	public static void Main()
	{
		int[,,] arr3d1 = new int[1, 2, 2]{
			{{1, 2}, {3, 4}} // 1 row of two-dimensional array
		};
		
		int[,,] arr3d2 = new int[2, 2, 2]{ // 2 rows of two-dimensional array
			{{1, 2}, {3, 4}}, 
			{{5, 6}, {7, 8}}
		};
		
		int[,,] arr3d3 = new int[2, 2, 3]{ // 2 rows of two-dimensional array
			{{1, 2, 3}, {4, 5, 6}}, 
			{{7, 8, 9}, {10, 11, 12}}
		};
		
		Console.WriteLine("arr3d2 Values");
		Console.WriteLine(arr3d2[0, 0, 0]);
		Console.WriteLine(arr3d2[0, 0, 1]);
		Console.WriteLine(arr3d2[0, 1, 0]);
		Console.WriteLine(arr3d2[0, 1, 1]);
		Console.WriteLine(arr3d2[1, 0, 0]);
		Console.WriteLine(arr3d2[1, 0, 1]);
		Console.WriteLine(arr3d2[1, 1, 0]);
		Console.WriteLine(arr3d2[1, 1, 1]);
	}
}