/*
1. A dictionary is a collection of (key, value) pairs.
2. Dictionary class is present in System.Collections.Generic namespace.
3. When creating a dictionary, we need to specify the type for key and value.
4. Dictionary provides fast lookups for values using keys.
5. Keys in the dictionary must be unique.
*/
using System;
using System.Collections.Generic;
public class Program
{
	public static void Main(string[] args)
	{
		Customer c1=new Customer()
		{
			Id=101,
			Name="Mark",
			Salary=5000
		};
		Customer c2=new Customer()
		{
			Id=102,
			Name="Pam",
			Salary=7000
		};
		Customer c3=new Customer()
		{
			Id=103,
			Name="Rob",
			Salary=5500
		};
		Dictionary<int,Customer> dictionaryofCustomers=new Dictionary<int,Customer>();
		dictionaryofCustomers.Add(c1.Id,c1);
		dictionaryofCustomers.Add(c2.Id,c2);
		dictionaryofCustomers.Add(c3.Id,c3);
		
		Customer cust;
		if(dictionaryofCustomers.TryGetValue(102,out cust))
		{
			Console.WriteLine("Id={0}, Name={1}, Salary={2}",cust.Id,cust.Name,cust.Salary);
		}
		else
		{
			Console.WriteLine("The key does not exist");
		}
	}
}
public class Customer
{
	public int Id{get;set;}
	public string Name{get;set;}
	public int Salary{get;set;}
}