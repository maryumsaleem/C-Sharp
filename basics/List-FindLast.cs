//FindLast() searches for an element that matches the condition defined by the specified lambda expression and returns the Last matching item from the list.

using System;
using System.Collections.Generic;
public class Program
{
	public static void Main(string[] args)
	{
		Customer customer1=new Customer()
		{
			Id=1,
			Name="Marc",
			Salary=20000
		};
		Customer customer2=new Customer()
		{
			Id=2,
			Name="John",
			Salary=30000
		};
		Customer customer3=new Customer()
		{
			Id=3,
			Name="Kim",
			Salary=15000
		};
		List<Customer> customerList=new List<Customer>(2);
		customerList.Add(customer1);
		customerList.Add(customer2);
		customerList.Add(customer3);
		
		//here find will return the first object that fulfils the condition
		Customer c=customerList.FindLast(cust=> cust.Salary>5000);
		Console.WriteLine("Id={0}, Name={1}, Salary={2}",c.Id,c.Name,c.Salary);
	}
}
public class Customer
{
	public int Id{get;set;}
	public string Name{get;set;}
	public int Salary{get;set;}
}
