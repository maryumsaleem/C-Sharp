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
		simplemethodDelegate del1,del2,del3,del4;
		del1=new simplemethodDelegate(simplemethodone);
		del2=new simplemethodDelegate(simplemethodtwo);
		del3=new simplemethodDelegate(simplemethothree);
		
		del4=del1+del2+del3;//here del4 is will be multicast delegate.
		del4();
		//- or -= is used to unregestering  method
		Console.WriteLine("\nUN-REGESTRING method 2:\n");
		del4=del1+del2+del3-del2;//here del4 is will be multicast delegate.
		del4();
		
		
		
		
	}
	public static void simplemethodone()
	{
		Console.WriteLine("Simple Method 1 Invoked");
	}
	public static void simplemethodtwo()
	{
		Console.WriteLine("Simple Method 2 Invoked");
	}
	public static void simplemethothree()
	{
		Console.WriteLine("Simple Method 3 Invoked");
	}
	
}