//List is one of the generic collection classes presents in System.Collections.Generic namespace.
//1- A list can be used to create a collection of any type e.g: we can create list of integers string and even of complex types.
//2- The objects stored in the  list can be accessed by index.
//3- Unlike arrays list can grow in size automatically.
//4- This class also provides methods to Search, Sort and manipulate the lists.
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
		
		for(int i=0;i<customerList.Count;i++)
		{
			Customer c=customerList[i];
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
