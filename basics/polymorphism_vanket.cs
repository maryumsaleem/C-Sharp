//Polymorphism enables us to invoke derived class method using base class reference variable at run time thats polymorphism.
using System;
public class Employee
{
	public string firstName="FN";
	public string lastName="LN";
	public virtual void PrintFullName()//writing virtual keyword with base class method shows that we can override this method in child class.
	{
		Console.WriteLine(firstName+" "+lastName);
	}
}
public class PartTimeEmployee:Employee
{
   public override void PrintFullName()
	{
		Console.WriteLine(firstName+" "+lastName+"-Part Time");
	}	
}
public class FullTimeEmployee:Employee
{
	public override void PrintFullName()
	{
		Console.WriteLine(firstName+" "+lastName+"-Full Time");
	}	
}
public class TemporaryEmployee:Employee
{
	/*public override void PrintFullName()
	{
		Console.WriteLine(firstName+" "+lastName+"-Temporary");
	}*/	
	//it will still use base class method
}
class Program
{
	public static void Main(string[] args)
	{
		Employee[] employees=new Employee[4];
		
		employees[0]=new Employee();
		employees[1]=new PartTimeEmployee();
		employees[2]=new FullTimeEmployee();
		employees[3]=new TemporaryEmployee();
		
		foreach(Employee e in employees)
		{
			e.PrintFullName();
		}
	}
}