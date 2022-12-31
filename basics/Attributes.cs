//Attributes allow you to add declarative information to your programs.this information can then be quiered at runtime using reflection.
//There are several pre defenied  attributes provided by .Net it is possible to create your own Custom Attributes.
//A few predefined attributes with in the .Net framework.
//Obsolete: Marks types and type members outdated
//WebMethod:To expose a method as an XML Web service method.
//Serializable: Indicates that a class can be serialized.
//an attribute is a class that inherits from System.Attribute base class.
using System;
using System.Collections.Generic;
public class Program
{
	public static void Main(string[] args)
	{
		Calculator.Add(20,10);
		//Console.WriteLine(Calculator.Add(new List<int>(){10,25,26}));
	}
}
public class Calculator
{
	[ObsoleteAttribute("Use Add(List<int>Numbers Method")]
	public static int Add(int firstNum, int secNum)
	{
		return firstNum+secNum;
	}
	public static int Add(List<int>Numbers)
	{
		int sum=0;
		foreach(int num in Numbers)
		{
		sum=sum+num;
		}
		return sum;
	}
}