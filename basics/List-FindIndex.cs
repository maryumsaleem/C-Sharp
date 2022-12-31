//FindIndex() returns the index of first item, that matches the condition specified by the lambda expression.There are two types of overloaded methods which allow us to specify the range of elements to search, with in the list.

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
		//FindIndex
	int index=customerList.FindIndex(cust=> cust.Salary>20000);
	Console.WriteLine("Index={0}",index);
	
	//FindIndex OVERLOADED version with first parameter as starting index.
	int index1=customerList.FindIndex(2,cust=> cust.Salary>5000);
	Console.WriteLine("Index of overloaded version={0}",index1);
	}
	
}
public class Customer
{
	public int Id{get;set;}
	public string Name{get;set;}
	public int Salary{get;set;}
}
