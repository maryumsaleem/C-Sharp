/*
1. A dictionary is a collection of (key, value) pairs.
2. Dictionary class is present in System.Collections.Generic namespace.
3. When creating a dictionary, we need to specify the type for key and value.
4. Dictionary provides fast lookups for values using keys.
5. Keys in the dictionary must be unique.
*/
using System;
using System.Collections.Generic;
using System.Linq;
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
		
		List <Customer> customersList=new List<Customer>();
		customersList.Add(c1);
		customersList.Add(c2);
		customersList.Add(c3);

		
		Dictionary<int,Customer> dictionaryofCustomers=customersList.ToDictionary(cust=> cust.Id,cust=>cust);	

		foreach(KeyValuePair<int,Customer> customerkeyvaluepair in dictionaryofCustomers)
		{
			Console.WriteLine("Key={0}",customerkeyvaluepair.Key);
			Customer cust=customerkeyvaluepair.Value;
			Console.WriteLine("Id={0}, Name={1}, Salary={2}",cust.Id,cust.Name,cust.Salary);
			Console.WriteLine("----------------------------------");
		}
	}
}
public class Customer
{
	public int Id{get;set;}
	public string Name{get;set;}
	public int Salary{get;set;}
}