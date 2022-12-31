using System;
					
public class Program
{
	public static void Main()
	{
		Action<int> printActionDel = ConsolePrint;
		
		//Or
		//Action<int> printActionDel = new Action<int>(ConsolePrint);
		
    	printActionDel(10);
	}
	
	public static void ConsolePrint(int i)
	{
		Console.WriteLine(i);
	}
}

/*
Points to Remember :
1-Action delegate is same as func delegate except that it does not return anything. Return type must be void.
2-Action delegate can have 0 to 16 input parameters.
3-Action delegate can be used with anonymous methods or lambda expressions.
*/