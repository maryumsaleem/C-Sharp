//Unlike Tuple, a ValueTuple can include more than eight values.
using System;

public class Program
{
	public static void Main()
	{
		ValueTuple<int, string, string> person1 = (1, "Bill", "Gates");
		Console.WriteLine(person1.Item1); // returns 1
		Console.WriteLine(person1.Item2); // returns "Bill"
		Console.WriteLine(person1.Item3); // returns "Gates"
				
		(int, string, string) person2 = (1, "James", "Bond");
		Console.WriteLine(person2.Item1); // returns 1
		Console.WriteLine(person2.Item2); // returns "James"
		Console.WriteLine(person2.Item3); // returns "Bond"
	}
}

//Tuple requires at least two values. The following is NOT a tuple.

//var number = (1);  // int type, NOT a tuple
//var numbers = (1,2); //valid tuple