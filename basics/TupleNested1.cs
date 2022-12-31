using System;
					
public class Program
{
	public static void Main()
	{
		var numbers = Tuple.Create(1, 2, Tuple.Create(3, 4, 5, 6, 7,  8), 9, 10, 11, 12, 13 );
		
		Console.WriteLine(numbers.Item1); // returns 1
		Console.WriteLine(numbers.Item2); // returns 2
		Console.WriteLine(numbers.Item3); // returns (3, 4, 5, 6, 7,  8)
		Console.WriteLine(numbers.Item3.Item1); // returns 3
		Console.WriteLine(numbers.Item4); // returns 9
		Console.WriteLine(numbers.Rest.Item1); //returns 13

		
	}
}
/*
Usage of Tuple
Tuples can be used in the following scenarios:

1-When you want to return multiple values from a method without using ref or out parameters.
2-When you want to pass multiple values to a method through a single parameter.
3-When you want to hold a database record or some values temporarily without creating a separate class.


Tuple Limitations:
1-The Tuple is a reference type and not a value type. It allocates on heap and could result in CPU intensive operations.
2-The Tuple is limited to include eight elements. You need to use nested tuples if you need to store more elements. However, this may result in ambiguity.
3-The Tuple elements can be accessed using properties with a name pattern Item<elementNumber>, which does not make sense
*/