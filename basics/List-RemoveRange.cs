//RemoveRange():- Remove() function removes only the first matching item from the list .RemoveAt() function, removes the item at the specified index in the list. RemoveAll() function removes all the items that matches the specified condition. RemoveRange() method removes a range of elements from the list. This function expects 2 parameters, i.e: the start index in the list and the number of elements to remove.If you want to remove all the elements from the list without specifiyng any condition, then use Clear() function. 

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
			Id=4,
			Name="jin",
			Salary=40000,
			Type="Corporate Customer"
		};
		Customer customer5=new Customer()
		{
			Id=5,
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
		 
		
		RetailcustomerList.InsertRange(3,CorporatecustomerList);
		
		RetailcustomerList.Remove(customer1);
		
		RetailcustomerList.RemoveAt(2);
		
		RetailcustomerList.RemoveAll(x=> x.Type == "Corporate Customer");
		
		//remove range m 0 index se le k agy tk 2 customer delete krdo, is m 0 is index number and to is count of customer.
		RetailcustomerList.RemoveRange(0,2);
		
		
		
		
		
		
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
