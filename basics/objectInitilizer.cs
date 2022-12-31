using System;
					
public class Program
{
	public static void Main()
	{
		Student std = new Student() { StudentID = 1, 
                                      StudentName = "Bill", 
                                      Age = 20, 
                                      Address = "New York"   
                                    };

		Console.WriteLine(std.StudentName);
	}
}

public class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
	public string Address { get; set; }

}