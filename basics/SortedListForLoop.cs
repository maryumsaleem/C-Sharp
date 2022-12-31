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
		
		for (int i = 0; i < numberNames.Count; i++)
		{
			Console.WriteLine("key: {0}, value: {1}", numberNames.Keys[i], numberNames.Values[i]);
		}
	}
}