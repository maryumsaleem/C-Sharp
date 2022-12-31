using System;


public class Program
{
	static Func<int,int, int> operation;
	
	//You can assign any method to the above func delegate that takes two int parameters and returns an int value.
	public static int Sum(int x, int y)
    {
        return x + y;
    }
	
	public static void Main()
	{
		Func<int,int, int> add = Sum;		

        int result = add(10, 10);

        Console.WriteLine(result); 
	}
}
/*
A Func delegate type can include 0 to 16 input parameters of different types. However, it must include an out parameter for the result. For example, the following Func delegate doesn't have any input parameter, and it includes only an out parameter.


*/