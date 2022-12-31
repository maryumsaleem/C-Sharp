using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		SortedList<int,string> numberNames = new SortedList<int,string>()
                                    {
                                        {3, "Three"},
                                        {1, "One"},
                                        {2, "Two"}
                                    };

		Console.WriteLine(numberNames[1]); //output: One
		Console.WriteLine(numberNames[2]); //output: Two
		Console.WriteLine(numberNames[3]); //output: Three
		//Console.WriteLine(numberNames[10]); //run-time KeyNotFoundException

		numberNames[2] = "TWO"; //updates value
		numberNames[4] = "Four"; //adds a new key-value if a key does not exists
		
		foreach(var kvp in numberNames)
    		Console.WriteLine("key: {0}, value: {1}", kvp.Key , kvp.Value );
	}