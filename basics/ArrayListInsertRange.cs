using System;
using System.Collections;
					
public class Program
{
	public static void Main()
	{
		ArrayList arlist1 = new ArrayList()
                {
                    100, 200, 600
                };

		ArrayList arlist2 = new ArrayList()
                {
                    300, 400, 500
                };
		arlist1.InsertRange(2, arlist2);

		foreach(var item in arlist1)
			Console.Write(item + ", ");
	}