/*Sorting a list of simple types like int,string,char etc, is straight forwarrd.Just invoke the sort() method on the list instance and the data will be automatically sorted in ascending order.
List<int> numbers =new List<int>{1,8,7,5,2,3,4,9,6};

If you want the data to be retrieved in descending order, use Reverse() method on the list instance.
numbers.Reverse();

However,when you do the same thing on a complex type like Customer,we get a runtime invalid operation exception -Failed to compare 2 elements in the array.This because, .NET runtime does not know, how to sort complex types.We have to tell the way we want data to be sorted in the list by implementing IComparable interface.

Q:How is the sort functionality working for simple like int,string,char etc?
There are several of them so types (int,string,decimal,char etc) have implemented IComparable interface already. 
*/
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
		
		customerList.Sort();
		
		foreach(Customer c in customerList)
		{
			Console.WriteLine("Id={0}, Name={1}, Salary={2}",c.Id,c.Name,c.Salary);
		}
		
		SortByName sortbyname=new SortByName();
		customerList.Sort(sortbyname);
		Console.WriteLine("Sorting by Name");
		foreach(Customer c in customerList)
		{
			Console.WriteLine(c.Name);
		}
		
		
	}
}
public class Customer:IComparable<Customer>
{
	public int Id{get;set;}
	public string Name{get;set;}
	public int Salary{get;set;}
	
	public int CompareTo(Customer other)
	{
		if(this.Salary>other.Salary)
			return 1;
		else if(this.Salary<other.Salary)
			return -1;
		else
			return 0;
	}
}
	//as CompareTo default return type is integer so we can also use it like this
	/*
	public int CompareTo(Customer other)
	{
		return this.Salary.CompareTo(other.Salary);
	}
	*/
	
	public class SortByName: IComparer<Customer>
	{
		public int Compare(Customer x, Customer y)
		{
			return x.Name.CompareTo(y.Name);
		}
	}

