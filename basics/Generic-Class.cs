//Generics are used for System.Collections.Generic
using System;
public class Program
{
	public static void Main(string[] args)
	{
		bool Equal=Calculator<string>.AreEqual("b","c");
		if(Equal)
		{
			Console.WriteLine("Equals");
		}
		else
		{
			Console.WriteLine("Not Equal");
		}
	}
}
public class Calculator<T>
{

	public static bool AreEqual( T value1,  T value2)
	{
		return value1.Equals(value2);
	}
}