using System;
public class program
{
	public static void Main(string[] args)
	{
		Employee.id=2;
		Employee.name="hani";
		Employee.display();
	}
}
public static class Employee
{
	public static int id{set;get;}
	public static string name{set;get;}
	public static void display()
	{
		Console.WriteLine("id="+id+"\nname="+name);
	}
}

/*
Rules for Static Class
1-Static classes cannot be instantiated.
2-All the members of a static class must be static; otherwise the compiler will give an error.
3-A static class can contain static variables, static methods, static properties, static operators, static events, and static constructors.
4-A static class cannot contain instance members and constructors.
5-Indexers and destructors cannot be static
6-var cannot be used to define static members. You must specify a type of member explicitly after the static keyword.
7-Static classes are sealed class and therefore, cannot be inherited.
8-A static class cannot inherit from other classes.
9-Static class members can be accessed using ClassName.MemberName.
10-A static class remains in memory for the lifetime of the application domain in which your program resides.
*/

//