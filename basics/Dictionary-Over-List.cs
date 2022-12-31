//why should we use Dictionary over List?
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
public class Program
{
	public static void Main(string[] args)
	{
		Country country1=new Country()
		{
			Code="AUS",
			Name="AUSTRALIA",
			Capital="Canberra"
		};
			Country country2=new Country()
		{
			Code="IND",
			Name="INDIA",
			Capital="New Dehli"
		};
			Country country3=new Country()
		{
			Code="USA",
			Name="UNITED STATES",
			Capital="Washington D.C"
		};
			Country country4=new Country()
		{
			Code="GBR",
			Name="UNITED KINGDOM",
			Capital="London"
		};
			Country country5=new Country()
		{
			Code="CAN",
			Name="CANADA",
			Capital="Ottawa"
		};
		
		List<Country> listCountries=new List<Country>(100);
		listCountries.Add(country1);
		listCountries.Add(country2);
		listCountries.Add(country3);
		listCountries.Add(country4);
		listCountries.Add(country5);
		
		Console.WriteLine("Please Enter Country Code");
		string strCountryCode=Console.ReadliLine().ToUpper();
		
		listCountries
	}
}
public class Country
{
	public string Code{get;set;}
	public string Name{get;set;}
	public string Capital{get;set;}
}
