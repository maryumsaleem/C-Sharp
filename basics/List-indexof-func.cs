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
		customerList.Add(customer1);//1
		customerList.Add(customer2);//2
		customerList.Add(customer3);//3
		//insert func
		customerList.Insert(0,customer3);// here 0 is index no of list customer3 will be inserted at index zero and pushdown other indexes.
		
		//index of func return index of object in list.
		Console.WriteLine("index of customer3={0}",customerList.IndexOf(customer3));
		
		//This is an overloaded version of IndexOf() function in which second parameter is index number of the object in the list from where it will start.
		Console.WriteLine("index of customer3 starting from object 1's index={0}",customerList.IndexOf(customer3,1));
		
		//This is another overloaded version of IndexOf() function in which second parameter is index number of the object in the list from where it will start and 3rd param is where it will stop basicaly it will start from index 1 and stops at 2, and it will give -1 output since customer3 object is not present in between index 1 to 2.
		Console.WriteLine("index of customer3 starting from object 1's index and ends at object 2's index={0}",customerList.IndexOf(customer3,1,2));
		
		
		
		//This is overloaded version of IndexOf() function in which second parameter is index number of the object in the list from where it will start and 3rd param is where it will stop basicaly it will start from index 1 and stops at 3.
		Console.WriteLine("index of customer3 starting from object 1's index and ends at object 3's index={0}",customerList.IndexOf(customer3,1,3));
		
		//it will give index out of range exception because 4th index is not in the list.
		Console.WriteLine("index of customer3 starting from object 1's index and ends at object 4's index={0}",customerList.IndexOf(customer3,1,4));
		
		
	}
}
public class Customer
{
	public int Id{get;set;}
	public string Name{get;set;}
	public int Salary{get;set;}
}
