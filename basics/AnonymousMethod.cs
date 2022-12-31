using System;
					
public class Program
{
	public delegate void Print(int value);
	
	public static void Main()
	{
		 int i = 10;
    //Anonymous methods can access variables defined in an outer function.
		Print prnt = delegate(int val) {
			val += i;
			Console.WriteLine("Anonymous method: {0}", val); 
		};
	
		prnt(100);
	}
}