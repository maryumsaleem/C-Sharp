using System;
using System.Collections;
	
public class Program
{
	public static void Main()
	{
		Hashtable numberNames = new Hashtable();
		numberNames.Add(1,"One"); //adding a key/value using the Add() method
		numberNames.Add(2,"Two");
		numberNames.Add(3,"Three");

		//The following throws run-time exception: key already added.
		//numberNames.Add(3, "Three"); 

		foreach(DictionaryEntry kvp in numberNames)
			Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

		//creating a dictionary using collection-initializer syntax
		var cities = new Hashtable(){
			{"UK", "London, Manchester, Birmingham"},
			{"USA", "Chicago, New York, Washington"},
			{"India", "Mumbai, New Delhi, Pune"}
		};

		foreach(DictionaryEntry kvp in cities)
			Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);		

	}
}