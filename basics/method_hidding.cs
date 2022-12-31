using System;
public class Employee
{
	public string firstName;
	public string lastName;
	public void printFullName()
	{
		Console.WriteLine(firstName+" "+lastName);
	}
}
public class PartTimeEmployee:Employee
{
	public new void printFullName() //adding new keyword for hidding method of parent class.
	{
		Console.WriteLine(firstName+" "+lastName+"- contrctor");
		base.printFullName();// this will call hidden base class method.
	}
	
}
public class FullTimeEmployee:Employee
{
	
}
class Program
{
	public static void Main(string[] args)
	{
		FullTimeEmployee FTE=new FullTimeEmployee();
		FTE.firstName="fulltime";
		FTE.lastName="Employee";
		FTE.printFullName();
		
		PartTimeEmployee PTE=new PartTimeEmployee();
		PTE.firstName="parttime";
		PTE.lastName="Employee";
		((Employee)PTE).printFullName();//you can also type cast an object to call parent class method.
		
		
		// A pareent class reference variable can hold child class object.
		/*
        -> here an parent class reference variable PTE is holding child class object new PartTimeEmployee() bcoz a child class holds all the properties of parent class.
		 
	    Employee PTE=new PartTimeEmployee();
		PTE.firstName="parttime";
		PTE.lastName="Employee";
		PTE.printFullName(); //it will print employee class method.
		*/
		
	}
}