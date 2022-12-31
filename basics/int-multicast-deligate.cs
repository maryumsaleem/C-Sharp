//A delegate that has reference to more than one functions.
//a multicast delegate,invokes the methods in the invocation list,in the same order in which they are added.
/*
if the delegate has return type of other than void and if the delegate is a multicast delegate,only the value of the last invoked method will be returned.Along the same lines, if the delegate has an out parameter,the value assigned by the last method.
*/
using System;
public delegate int simplemethodDelegate();
public class Program
{
	public static void Main(string[] args)
	{
		//simplemethodDelegate del=new simplemethodDelegate(simplemethod);
		//del();
		simplemethodDelegate del1=new simplemethodDelegate(simplemethodone);
		
		del1+=simplemethodtwo;//here del1 is will be multicast delegate
	int output=del1();
		Console.WriteLine("output:"+output);
		
	}
	public static int simplemethodone()
	{
		return 1;
	}
	public static int simplemethodtwo()
	{
		return 2;
	}

}