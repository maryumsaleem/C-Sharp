/*
AsReadOnlly():Returns a readonly wrapper for the current collection.Use this method, if you dont want the client code to modify the collection i.e add or remove any elements from the collection.The ReadOnly Collection will not have methods to add or remove items from the collection.You can only read items from this collection.
*/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
		
		ReadOnlyCollection<Customer> readonlyCustomers=customerList.AsReadOnly();
		Console.WriteLine("Items="+readonlyCustomers.Count);
		foreach(Customer c in customerList)
		{
			Console.WriteLine("Id={0}, Name={1}, Salary={2}",c.Id,c.Name,c.Salary);
		}
	}
}
public class Customer
{
	public int Id{get;set;}
	public string Name{get;set;}
	public int Salary{get;set;}
}
