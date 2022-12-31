using System;
class Program
{
	public static void Main()
	{
		int i=0;
		simpleMethod(ref i);
		Console.WriteLine(i);
	}
	public static void simpleMethod(ref int j)
	{
	j=101;	
	}
}