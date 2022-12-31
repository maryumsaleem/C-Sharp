using System;
					
public class Program
{
	public static void Main()
	{
		int[][][] intJaggedArray = new int[2][][]
		{
			new int[2][]//0
			{ 
				new int[3] { 1, 2, 3},//0
				new int[2] { 4, 5} //1
			},
			
			new int[1][]//1
			{ 
				new int[3] { 7, 8, 9}//0
			}
		};

		Console.WriteLine(intJaggedArray[0][0][0]); // 1

		Console.WriteLine(intJaggedArray[0][1][1]); // 5

		Console.WriteLine(intJaggedArray[1][0][2]); // 9
		Console.WriteLine(intJaggedArray[0][1][0]); // 4
	}
}