//AddaRange():Add() method allows us to add one item at a time to the end of the list,where as AddRange() allows you to add another list of items, to the end of the list.

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
		 
		 RetailcustomerList.AddRange(CorporatecustomerList);
		
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
