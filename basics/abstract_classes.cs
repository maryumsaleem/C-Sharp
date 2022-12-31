using System;
//abstract class dont provide the implementation of its members
//you cannot instantiate an abstract class.
public abstract class Customer
{
	public abstract void Print();
}
public class Program:Customer
{
	public override void Print()
	{
		Console.WriteLine("Print Method");
	}
	public static void Main(string[] args)
	{
		Program p=new Program();
		p.Print();
		//you can also create object reference variable of abstract class and pointint towards inherited class object
		Customer c=new Program();
		c.Print();
		
	}
}