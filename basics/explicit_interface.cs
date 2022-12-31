using System;
interface I1
{
	void print();
}
interface I2
{
	void print();
}

public class Program:I1,I2
{
	void I1.print()
	{
		Console.WriteLine("I1 print method");
	}
	void I2.print()
	{
		Console.WriteLine("I2 print method");
	}
public static void Main(string[] args)
{
	Program p=new Program();
	((I1)p).print();
	I2 obj=new Program();
	obj.print();
	//((I2)p).print();
	//another way to do it
}	
}