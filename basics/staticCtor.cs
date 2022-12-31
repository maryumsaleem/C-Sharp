using System;
					
public class Program
{
	public static void Main()
	{
		StopWatch.DisplayInfo(); // static constructor called here
		StopWatch.DisplayInfo(); // none of the constructors called here
		
		//StopWatch sw1 = new StopWatch(); // First static constructor and then instance constructor called 
		//StopWatch sw2 = new StopWatch();// only instance constructor called 
		//StopWatch.DisplayInfo();
	}
}
public class StopWatch
{
    // static constructor
    static StopWatch()
    {
        Console.WriteLine("Static constructor called");
    }

    // instance constructor
    public StopWatch()
    {
        Console.WriteLine("Instance constructor called");
    }

    // static method
    public static void DisplayInfo()
    {
        Console.WriteLine("DisplayInfo called");
    }

    // instance method
    public void Start() { }

    // instance method
    public void Stop() {  }
}

/*
he static constructor is called only once whenever the static method is used or creating an instance for the first time. The following example shows that the static constructor gets called when the static method called for the first time. Calling the static method second time onwards won't call a static constructor.
*/

/*
Rules for Static Constructors
1-The static constructor is defined using the static keyword and without using access modifiers public, private, or protected.
2-A non-static class can contain one parameterless static constructor. Parameterized static constructors are not allowed.
3-Static constructor will be executed only once in the lifetime. So, you cannot determine when it will get called in an application if a class is being used at multiple places.
4-A static constructor can only access static members. It cannot contain or access instance members.
*/