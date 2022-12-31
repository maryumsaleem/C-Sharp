//Exists() function:Checks if an item exists in the list.This method returns true if the item exists,else false.
//Difference between contains and exist is that Contains() take an object as parameter where as Exists() takes lambda expression like predicate.
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
		
		if(customerList.Exists(cust=> cust.Name.StartsWith("K")))
		{
			Console.WriteLine("exists in the list");
		}
		else
		{
			Console.WriteLine("does not exists in the list");
		}
	}
}
public class Customer
{
	public int Id{get;set;}
	public string Name{get;set;}
	public int Salary{get;set;}
}
