using System;
//step1:defining a delegate
public delegate void MyDelegate(string msg);

public class Program
{
	public static void Main()
	{
		//instantianting a delegate
		//one way of making instance of a delegate
		//MyDelegate del = ClassA.MethodA; this method is called group conversion
		//another way of making instance of a delegate
		MyDelegate del = new MyDelegate(ClassA.MethodA);
		del("Hello World");
			
		del = ClassB.MethodB;
		del("Hello World");
		
		del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
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
Points to Remember :
1-Delegate is the reference type data type that defines the signature.
2-Delegate type variable can refer to any method with the same signature as the delegate.
3-Syntax: [access modifier] delegate [return type] [delegate name]([parameters])
A target method's signature must match with delegate signature.
4-Delegates can be invoke like a normal function or Invoke() method.
5-Multiple methods can be assigned to the delegate using "+" or "+=" operator and removed using "-" or "-=" operator. It is called multicast delegate.
6-If a multicast delegate returns a value then it returns the value from the last assigned target method.
7-Delegate is used to declare an event and anonymous methods in C#.

*/