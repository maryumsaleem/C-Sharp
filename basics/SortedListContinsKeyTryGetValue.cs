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
		
		if(!numberNames.ContainsKey(4))//check if key exists
		{
			numberNames[4] = "Four";
		}
			
		string result;
			
		if(numberNames.TryGetValue(4, out result)) // try to get value of 4 key
			Console.WriteLine("Key: {0}, Value: {1}", 4, result);
		
	}
}