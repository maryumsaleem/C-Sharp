using System;
					
public class Program
{
	public static void Main()
	{
		Student std = null;

		try
		{
			PrintStudentName(std);
		}
		catch(Exception ex)
		{
			Console.WriteLine(ex.Message );
		}                      
	
		Console.ReadKey();
	}
	
	public static void PrintStudentName( Student std)
	{
		if (std  == null)
			throw new NullReferenceException("Student object is null. ");
			
		Console.WriteLine(std.StudentName);
	}
}

public class Student{

	public string StudentName { get; set; }
}

/*
Please notice that throw creates an object of any valid exception type using the new keyword. The throw keyword cannot be used with any other type which does not derive from the Exception class.
*/