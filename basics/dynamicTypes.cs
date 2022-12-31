using System;
public class program
{
	public static void Main(string[] args)
	{
		dynamic MyDynamicVar=100;
		Console.WriteLine("Value:{0},Type: {1}",MyDynamicVar,MyDynamicVar.GetType());
		MyDynamicVar="Hello World";
		Console.WriteLine("Value:{0},Type:{1}",MyDynamicVar,MyDynamicVar.GetType());
		MyDynamicVar=true;
		Console.WriteLine("Value:{0},Type:{1}",MyDynamicVar,MyDynamicVar.GetType());
		MyDynamicVar=DateTime.Now;
		Console.WriteLine("Value:{0},Type:{1}",MyDynamicVar,MyDynamicVar.GetType());
		dynamic std=new student();
		std.dissplayStudentInfo(1123);
		std.FakeMethod();
		
	}
}
public class student
{
	public void dissplayStudentInfo(int id)
	{
		Console.WriteLine("Dummy Student");
	}
}