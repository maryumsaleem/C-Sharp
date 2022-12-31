//Arry to list using ToList() method.
using System;
using System.Collections.Generic;
using System.Linq;// this needs to be added for ToList() method.
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
		Customer[] CustomerArray=new Customer[3];
		CustomerArray[0]=customer1;
		CustomerArray[1]=customer2;
		CustomerArray[2]=customer3;
		
		List<Customer> customerList=CustomerArray.ToList();
		
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
