using System;
using System.Reflection;
namespace maryum
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//Type T=Type.GetType("maryum.Customer");
			Type T=typeof(Customer); //you cn also use typeof keyword instead of above line
			Console.WriteLine("Full Name={0}",T.FullName);
			Console.WriteLine("Just the Name={0}",T.Name);
			Console.WriteLine("Just the NameSpace={0}",T.Namespace);
			
			
			//for displaying properties
			Console.WriteLine("\nProperties in Customer");
			PropertyInfo[] properties=T.GetProperties();
			foreach(PropertyInfo p in properties)
			{
				Console.WriteLine(p.PropertyType.Name+" "+p.Name);
			}
			
			//for displaying Methods
			Console.WriteLine("\nMethods in Customer");
			MethodInfo[] methods=T.GetMethods();
			foreach(MethodInfo m in methods)
			{
				Console.WriteLine(m.ReturnType.Name+" "+m.Name);
			}
			
			//for displaying Constructor
			Console.WriteLine("\nConstructor in Customer");
			ConstructorInfo[] constructors=T.GetConstructors();
			foreach(ConstructorInfo c in constructors)
			{
				Console.WriteLine(c.ToString());
			}
			
			
		}
	}

internal class Customer
{
	public int Id{get;set;}
	public string Name{get;set;}
	
	public Customer(int id,string name)
	{
		this.Id=id;
		this.Name=name;
	}
	public Customer()
	{
		this.Id=-1;
		this.Name=string.Empty;
	}
	
	public void PrintId()
	{
		Console.WriteLine("Id={0}",this.Id);
	}
	
		public void PrintName()
	{
		Console.WriteLine("Name={0}",this.Name);
	}
}
}