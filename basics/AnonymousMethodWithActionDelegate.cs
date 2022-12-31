//An Action delegate can take up to 16 input parameters of different types.

//An Anonymous method can also be assigned to an Action delegate, for example:
using System;
					
public class Program
{
	public static void Main()
	{
		Action<int> printActionDel = delegate(int i)
									{
										Console.WriteLine(i);
									};

   		printActionDel(10);
	}
}