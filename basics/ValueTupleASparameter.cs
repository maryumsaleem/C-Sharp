using System;

public class Program
{
	static void Main(string[] args)
	{
		DisplayTuple((1, "Bill", "Gates"));
	}

	static void DisplayTuple((int, string, string) person)
	{
	    Console.WriteLine("{0}, {1}, {2}", person.Item1, person.Item2, person.Item3);
	}
}

/*
ValueTuple as Parameter:

The ValueType can also be a parameter type or return type of a method. The following method accepts a ValueTuple type parameter.
*/