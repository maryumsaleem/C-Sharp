using System;

public class Program
{
	static void Main(string[] args)
	{
		var person = GetPerson();
		Console.WriteLine("{0}, {1}, {2}", person.Item1, person.Item2, person.Item3);
	}

	static (int, string, string) GetPerson()
	{
		return (1,  "Bill", "Gates");
	}
}
/*
You can also specify member names for a ValueTuple returned from the method.

static (int Id, string FirstName, string LastName) GetPerson()
	{
		return (Id: 1, FirstName: "Bill", LastName: "Gates");
	}
	*/