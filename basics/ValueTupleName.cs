using System;

public class Program
{
	public static void Main()
	{
		(int Id, string FirstName, string LastName) person = (1, "Bill", "Gates");
		Console.WriteLine(person.Id); // returns 1
		Console.WriteLine(person.FirstName); // returns "Bill"
		Console.WriteLine(person.LastName); // returns "Gates"
	}
}
/*
Named Members
We can assign names to the ValueTuple properties instead of having the default property names like Item1, Item2 and so on.
*/

/*
We can also assign member names on the right side with values, as below.

var person = (Id:1, FirstName:"Bill", LastName: "Gates");
*/

/*
Please note that we can provide member names either on the left or right sides but not on both sides. The left side has precedence over the right side. The following will ignore names on the right side.

// PersonId, FName, LName will be ignored.
(int Id, string FirstName, string LastName) person = (PersonId:1, FName:"Bill", LName: "Gates");

// PersonId, FirstName, LastName will be ignored. It will have the default names: Item1, Item2, Item3.
(string, string, int) person = (PersonId:1, FName:"Bill", LName: "Gates");

*/

/*
We can also assign variables as member values:

string firstName = "Bill", lastName = "Gates";
var per = (FirstName: firstName, LastName: lastName);
*/