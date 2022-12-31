using System;

public class Program
{
	static void Main(string[] args)
	{
		(int Id, string FirstName, string LastName)  = GetPerson();
		Console.WriteLine("{0},{1}, {2}", Id, FirstName, LastName);
		
		(var PersonId, var FName, var LName) = GetPerson(); // using var
		Console.WriteLine("{0},{1}, {2}", PersonId, FName, LName);
		
		(var PId, var Name, _) = GetPerson(); //discard other members
		Console.WriteLine("{0},{1}", PId, Name);
	}

	static (int, string, string) GetPerson()
	{
		return (Id: 1, FirstName: "Bill", LastName: "Gates");
	}
}
/*
Deconstruction:

Individual members of a ValueTuple can be retrieved by deconstructing it. A deconstructing declaration syntax splits a ValueTuple into its parts and assigns those parts individually to fresh variables.
*/

/*
We can also use var instead of explicit data type names.

Example: Deconstruct ValueTuple Copy
static void Main(string[] args)
{
    // use var as datatype
    (var PersonId, var FName, var LName) = GetPerson();
}
static (int, string, string) GetPerson() 
{
    return (Id:1, FirstName: "Bill", LastName: "Gates");
}
*/

/*
ValueTuple also allows "discards" in deconstruction for the members you are not going to use.

// use discard _ for the unused member LName
(var id, var FName, _) = GetPerson(); 
*/