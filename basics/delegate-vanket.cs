//delegte is a type safe function pointer,it holds a reference(pointer) to a function.
//the signature of the delegate must match to the signature of function which it is pointing to thats why delegates are called type safe function pointer.
//A delegate is similar to class.you can create instance of it just like class,you pass in the function name as a parameter to the delegate cunstructor,and it is to this function delegate will point to.

using System;
public delegate void HelloFunctionDelegate(string str);
public class Program
{
	public static void Main(string[] args)
	{
		HelloFunctionDelegate obj=new HelloFunctionDelegate(Hello);
		obj("Hello from delegate");
	}
	public static void Hello(string str)
	{
		Console.WriteLine(str);
	}
}