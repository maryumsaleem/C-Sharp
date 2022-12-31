// keypoint to be noted: When you need to pass in a function as a parameter to another function , you can use Delegate!
using System;
using System.Collections.Generic;
 class Program
{
	public static void Main()
	{
		List<Employee> emplist=new List<Employee>();
		
		emplist.Add(new Employee() {id=1,name="marry",salary=1000,Experience=1});
		emplist.Add(new Employee() {id=2,name="harry",salary=2000,Experience=8});
		emplist.Add(new Employee() {id=3,name="sharry",salary=3000,Experience=7});
		emplist.Add(new Employee() {id=4,name="carry",salary=4000,Experience=4});
		 
		IsPromotable isPromotble=new IsPromotable(Promote);
		
		Employee.PromoteEmployee(emplist,isPromotble);
	}
	public static bool Promote(Employee emp)
	{
		if(emp.Experience>=5)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
}
public delegate bool IsPromotable(Employee empl);

public class Employee
{
	public int id{get;set;}
	public string name{get;set;}
	public int salary{get;set;}
	public int Experience{get;set;}
	
	public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
	{
		foreach(Employee employee in employeeList)
		{
			if(IsEligibleToPromote(employee))
			{
				Console.WriteLine(employee.name +  " promoted");
			}
		}
	}
}