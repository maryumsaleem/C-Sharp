using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		var students = new List<Student>() { 
                new Student(){ Id = 1, Name="Bill" },
                new Student(){ Id = 2, Name="Steve" },
                new Student(){ Id = 3, Name="Ram" },
                new Student(){ Id = 4, Name="Abdul" },
				new Student(){ Id = 5, Name="Bill" }
		};
		
		//get all students whose name is Bill
		var studNames = from s in students
			where s.Name == "Bill"
			select s;
		
		foreach(var student in studNames)
			Console.WriteLine(student.Id + ", " +student.Name);
	}
}

public class Student
{ 
	public int Id { get; set; }
	public string Name { get; set; }
}