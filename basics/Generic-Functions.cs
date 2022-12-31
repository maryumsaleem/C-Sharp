//Generics are used for System.Collections.Generic
using System;
public class Program
{
	public static void Main(string[] args)
	{
		bool Equal=Calculator.AreEqual<int>(20,20);
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
public class Calculator
{

	public static bool AreEqual<T>( T firstNum,  T secNum)
	{
		return firstNum.Equals(secNum);
	}
}