using System;
interface IA
{
	void AMethod();
}
public class A:IA
{
	public void AMethod()
	{
		Console.WriteLine("AMethod");
	}
}

interface IB
{
	void BMethod();
}
public class B:IB
{
	public void BMethod()
	{
		Console.WriteLine("BMethod");
	}
}

public class AB:IA,IB
{
	A a=new A();
	B b=new B();
	public void AMethod()
	{
		a.AMethod();
	}
	public void  BMethod()
	{
		b.BMethod();
	}
}
public class Program
{
	public static void Main(string[] args)
	{
	AB obj=new AB();
	obj.AMethod();
	obj.BMethod();
	}
}