//A delegate that has reference to more than one functions.
//a multicast delegate,invokes the methods in the invocation list,in the same order in which they are added.
/*
if the delegate has return type of other than void and if the delegate is a multicast delegate,only the value of the last invoked method will be returned.Along the same lines, if the delegate has an out parameter,the value assigned by the last method.
*/
using System;
public delegate void simplemethodDelegate();
public class Program
{
	public static void Main(string[] args)
	{
		//simplemethodDelegate del=new simplemethodDelegate(simplemethod);
		//del();
		simplemethodDelegate del1;
		del1=new simplemethodDelegate(simplemethodone);
		
		del1+=simplemethodtwo;//here del1 is will be multicast delegate
		del1+=simplemethodthree;
		del1();
		//- or -= is used to unregestering  method
		Console.WriteLine("\nUN-REGESTRING method 1:\n");
		del1-=simplemethodone;
		del1();
	
		
		
		
		
	}
	public static void simplemethodone()
	{
		Console.WriteLine("Simple Method 1 Invoked");
	}
	public static void simplemethodtwo()
	{
		Console.WriteLine("Simple Method 2 Invoked");
	}
	public static void simplemethodthree()
	{
		Console.WriteLine("Simple Method 3 Invoked");
	}
	
}