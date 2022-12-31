//enums are strongly typed constnants.
//enums are used to replace set of integrals so that program can be more Readable and maintainable.
using System;
class Program
{
	public static void Main(string[] args)
	{
		Customer[] c=new Customer[3];
		c[0]= new Customer{
			Name="Mark",
			Gender2=Gender.Unkown
		};
		
		c[1]= new Customer{
			Name="John",
			Gender2=Gender.Male
		};
		c[2]= new Customer{
			Name="John",
			Gender2=Gender.Female
		};
		foreach(Customer cc in c)
		{
	Console.WriteLine("Name={0} && Gender={1}",cc.Name,getGender(cc.Gender2));
		}
	}
	public static string getGender(Gender g)
	{
		switch(g)
		{
			case Gender.Unkown:
			return "Unkown";
			
			case Gender.Male:
			return "Male";
			
			case Gender.Female:
			return "Female";
			default:
			return "Invalid data detected";
			
		}
	}
}

public enum Gender
{
	Unkown,
	Male,
	Female
}
public class Customer
{
	public string Name{get;set;}
	public Gender Gender2{get;set;}
}