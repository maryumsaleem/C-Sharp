using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Stack<int> myStack = new Stack<int>();
		myStack.Push(1);
		myStack.Push(2);
		myStack.Push(3);
		myStack.Push(4);
		
		Console.WriteLine(myStack.Contains(2)); 
		Console.WriteLine(myStack.Contains(10)); 
	}
}