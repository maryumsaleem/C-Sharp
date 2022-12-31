//Adding Dictionary to Hashtable
using System;
using System.Collections;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		Dictionary<int, string> dict = new Dictionary<int, string>();
		
		dict.Add(1, "one");
		dict.Add(2, "two");
		dict.Add(3, "three");
		
		Hashtable ht = new Hashtable(dict);
		
		Console.WriteLine("Total elements: {0}", ht.Count);
		
	}
}