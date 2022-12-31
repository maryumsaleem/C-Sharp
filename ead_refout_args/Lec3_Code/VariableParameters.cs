using System;

class Program
{
    static void Main()
    {
	//
	// Call params method with one to four integer constant parameters.
	//
	int sum1 = SumParameters(1);
	int sum2 = SumParameters(1, 2);
	int sum3 = SumParameters(3, 3, 3);
	int sum4 = SumParameters(2, 2, 2, 2);
	//
	// Write results of the method invocations.
	//
	Console.WriteLine(sum1);
	Console.WriteLine(sum2);
	Console.WriteLine(sum3);
	Console.WriteLine(sum4);
    }

    static int SumParameters(params int[] values)
    {
	//
	// Loop through and sum the integers in the array.
	//
	int total = 0;
	foreach (int value in values)
	{
	    total += value;
	}
	return total;
    }
}