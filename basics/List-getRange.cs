//getRange():using an item index,we can retrieve only one item at a time from the list,if you want to get a list of items from the list, then use GetRange() function.This function expects 2 parameters, i.e: the start index in the list and the number of elements to return.

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
			Salary=20000,
			Type="Retil Customer"
		};
		Customer customer2=new Customer()
		{
			Id=2,
			Name="John",
			Salary=30000,
			Type="Retil Customer"
		};
		Customer customer3=new Customer()
		{
			Id=3,
			Name="Kim",
			Salary=15000,
			Type="Retil Customer"
		};
		Customer customer4=new Customer()
		{
			Id=3,
			Name="jin",
			Salary=40000,
			Type="Corporate Customer"
		};
		Customer customer5=new Customer()
		{
			Id=3,
			Name="kane",
			Salary=50000,
			Type="Corporate Customer"
		};
		List<Customer> RetailcustomerList=new List<Customer>();
		 RetailcustomerList.Add(customer1);
		 RetailcustomerList.Add(customer2);
		 RetailcustomerList.Add(customer3);
		 
		 
		List<Customer> CorporatecustomerList=new List<Customer>();
		 CorporatecustomerList.Add(customer4);
		 CorporatecustomerList.Add(customer5);
		 
		
		List<Customer> customer=RetailcustomerList.GetRange(0,3);
		
		foreach(Customer c in RetailcustomerList)
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
	public string Type{get;set;}
}
