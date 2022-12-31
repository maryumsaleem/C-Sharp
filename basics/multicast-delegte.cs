using System;
public delegate void simplemethodDelegate();
public class Program
{
	public static void Main(string[] args)
	{
		simplemethodDelegate del=new simplemethodDelegate(simplemethod);
		del();
	}
	public static void simplemethod()
	{
		Console.WriteLine("Simple Method Invoked");
	}
}