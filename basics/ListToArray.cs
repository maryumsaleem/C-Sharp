//List to Array using ToArray() method.
using System;
using System.Collections.Generic;
using System.Linq;// this needs to be added for ToArray() method.
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
		List<Customer> customeerList=new List<Customer>();
		customeerList.Add(customer1);
		customeerList.Add(customer2);
		customeerList.Add(customer3);
		
		Customer[] CustomerArray=customeerList.ToArray();
		
		foreach(Customer c in CustomerArray)
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
