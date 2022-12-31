using System;

public delegate void MyDelegate(string msg);

public class Program
{
	public static void Main()
	{
		MyDelegate del = ClassA.MethodA;
		InvokeDelegate(del);		
		
		del = ClassB.MethodB;
		InvokeDelegate(del);
		
		del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
		InvokeDelegate(del);

	}
	
	public static void InvokeDelegate(MyDelegate del)
	{
		del("Hello World");
	}
}

public class ClassA
{
	public static void MethodA(string message)
	{
		Console.WriteLine("Called ClassA.MethodA() with parameter: "+ message);
	}
}

public class ClassB
{
	public static void MethodB(string message)
	{
		Console.WriteLine("Called ClassB.MethodB() with parameter: "+ message);
	}
}

/*
Anonymous Method Limitations
1-It cannot contain jump statement like goto, break or continue.
2-It cannot access ref or out parameter of an outer method.
3-It cannot have or access unsafe code.
4-It cannot be used on the left side of the is operator.

 Points to Remember :
1-Anonymous method can be defined using the delegate keyword
2-Anonymous method must be assigned to a delegate.
3-Anonymous method can access outer variables or functions.
4-Anonymous method can be passed as a parameter.
5-Anonymous method can be used as event handlers.
*/