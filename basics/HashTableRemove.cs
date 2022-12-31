using System;
using System.Collections;

public class Program
{
	public static void Main()
	{
		var cities = new Hashtable(){
			{"UK", "London, Manchester, Birmingham"},
			{"USA", "Chicago, New York, Washington"},
			{"India", "Mumbai, New Delhi, Pune"}
		};

		Console.WriteLine("Total Elements: {0}", cities.Count);
		
		cities.Remove("UK"); // removes UK 
		//cities.Remove("France"); //throws run-time exception: KeyNotFoundException

		Console.WriteLine("Total Elements: {0}", cities.Count);
		
		if(cities.ContainsKey("France")){ // check key before removing it
			cities.Remove("France");
		}

		cities.Clear(); //removes all elements
		Console.WriteLine("Total Elements after Clear(): {0}", cities.Count);

	}
}