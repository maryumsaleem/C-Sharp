using System;

public class Program
{
	static int counter = 0;
    string name = "Demo Program";
	
	public static void Main()
	{
		StopWatch sw1 = new StopWatch();
		StopWatch sw2 = new StopWatch();
		Console.WriteLine(StopWatch.NoOfInstances);
			
		StopWatch sw3 = new StopWatch();
		StopWatch sw4 = new StopWatch();
		Console.WriteLine(StopWatch.NoOfInstances);

	}

}

public class StopWatch
{
	public static int NoOfInstances = 0;
	
	public StopWatch()
	{
		StopWatch.NoOfInstances++;
	}
}

/*
Rules for Static Methods
1-Static methods can be defined using the static keyword before a return type and after an access modifier.
2-Static methods can be overloaded but cannot be overridden.
3-Static methods can contain local static variables.
4-Static methods cannot access or call non-static variables unless they are explicitly passed as parameters.
*/