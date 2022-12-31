using System;



public class Student{

	public string StudentName { get; set; }
	
}

public class Program
{
	public static void ChangeReferenceType(Student std2)
	{
		std2.StudentName   = "Steve";
	}
	
	public static void Main()
	{
		Student std1 = new Student();
		
		std1.StudentName = "Bill";
		
		ChangeReferenceType(std1);
	
		Console.WriteLine(std1.StudentName);
	}
}
/*
In the above example, we pass the Student object std1 to the ChangeReferenceType() method. Here, it actually pass the memory address of std1. Thus, when the ChangeReferenceType() method changes StudentName, it is actually changing StudentName of std1 object, because std1 and std2 are both pointing to the same address in memory.

String is a reference type, but it is immutable. It means once we assigned a value, it cannot be changed. If we change a string value, then the compiler creates a new string object in the memory and point a variable to the new memory location. So, passing a string value to a function will create a new variable in the memory, and any change in the value in the function will not be reflected in the original value, as shown below.
*/