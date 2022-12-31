using System;
class Program
{
	public static void Main()
	{
		int[] Numbers=new int[3];
		Numbers[0]=101;
		Numbers[1]=102;
		Numbers[2]=103;
		//ParamsMethod(); you can use this line without giving an int array argument bcoz there is params keyword in methods array parameter
		//ParamsMethod(Numbers); you cn use this s well
		ParamsMethod(1,2,3,4,5,6); //or you can give as many arguments as you want.
	}
	public static void ParamsMethod(params int[] Numbers)
	{
		Console.WriteLine("There are {0} elements",Numbers.Length);
		foreach(int n in Numbers)
		{
			Console.WriteLine(n);
		}
	}
	
}
/*parameter arrays: the param keyword lets you specify a method parameter that takes a variable number of arguments. you can send a comma-seperated list of arrguments,or an array,or no arrguments.Params keyword
should be the last one in method declaration, and only one params keyword is premmited in a method declaration.*/