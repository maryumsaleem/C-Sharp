using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		int[] arr = new int[]{ 1,2,3,4};
		Stack<int> myStack = new Stack<int>(arr);
		
		foreach(var itm in myStack)
			Console.Write(itm + ",");
	}
}