using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Queue<int> callerIds = new Queue<int>();
		callerIds.Enqueue(1);
		callerIds.Enqueue(2);
		callerIds.Enqueue(3);
		callerIds.Enqueue(4);

		foreach(var id in callerIds)
			Console.WriteLine(id);
	}
}