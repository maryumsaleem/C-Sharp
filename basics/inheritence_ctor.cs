using System;
public class Parent
{
	public Parent()
	{
		Console.WriteLine("Parent class Cunstructor Called");
	}
	public Parent(string message)
	{
		Console.WriteLine(message);
	}
}
public class Child:Parent
{
	public Child():base("Derived class controling Parent class")
	{
		Console.WriteLine("Child class cunstructror caleed");
	}
}

class Program
{
	public static void Main()
	{
	
	Child c=new Child();
	}
}