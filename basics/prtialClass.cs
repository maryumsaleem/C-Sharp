using System;
public partial class Employee
{
	public static void Main()
	{
	Employee e1=new Employee(12,"ali");
	e1.DisplayEmpInfo();
	}
}

public partial class Employee
{
    public int EmpId;
    public string Name;
	partial void DisplayEmpInfo();
}

public partial class Employee
{
    //constructor
    public Employee(int id, string name)
	{
        this.EmpId = id;
        this.Name = name;
    }

    partial void DisplayEmpInfo() 
	{
        Console.WriteLine(this.EmpId + " " +this.Name);
    }
}

/*Rules for Partial Classes
1-All the partial class definitions must be in the same assembly and namespace.
2-All the parts must have the same accessibility like public or private, etc.
3-If any part is declared abstract, sealed or base type then the whole class is declared of the same type.
4-Different parts can have different base types and so the final class will inherit all the base types.
5-The Partial modifier can only appear immediately before the keywords class, struct, or interface.
6-Nested partial types are allowed.*/

/*
Rules for Partial Methods
1-Partial methods must use the partial keyword and must return void.
2-Partial methods can have in or ref but not out parameters.
3-Partial methods are implicitly private methods, so cannot be virtual.
4-Partial methods can be static methods.
5-Partial methods can be generic.*/