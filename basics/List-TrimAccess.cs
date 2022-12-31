//TrimExcess():Sets the capacity to the actual number of elements in the list if that number is less than a threshold value.

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
		List<Customer> customerList=new List<Customer>(100);
		customerList.Add(customer1);
		customerList.Add(customer2);
		customerList.Add(customer3);
		
		Console.WriteLine("Capacity before Trimming="+customerList.Capacity);
		customerList.TrimExcess();
		Console.WriteLine("Capacity after Trimming="+customerList.Capacity);
		
	}
}
public class Customer
{
	public int Id{get;set;}
	public string Name{get;set;}
	public int Salary{get;set;}
}
