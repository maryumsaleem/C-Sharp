using System;
					
public class Program
{
	public static void Main()
	{
		Action<int> printActionDel = i => Console.WriteLine(i);
       
    	printActionDel(10);
	}
}