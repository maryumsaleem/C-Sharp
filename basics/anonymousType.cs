using System;

public class Program
{
	public static void Main()
	{
		var student = new { Id = 1,
		FirstName = "James",
		LastName = "Bond",
		Address = new { Id = 1, City = "London", Country = "UK" }
		};

		Console.WriteLine(student.Id); //output: 1
		Console.WriteLine(student.FirstName); //output: James
		Console.WriteLine(student.LastName); //output: Bond
		Console.WriteLine(student.Address.City);
		//the following will give compile-time error
		//student.Id = 2; //error
		//student.FirstName = "Steve"; //error
	}
}