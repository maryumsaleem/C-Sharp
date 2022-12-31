using System;
namespace app{
public class program
{
	static void Method(string fname="anya",int age=50)
	{//default parameters
		Console.WriteLine(fname+" "+age);
	}
	//named arguments
	static void MyMethod(string child1,string child2,string child3)
	{
		Console.WriteLine("The youngest child is "+child3);
	}
	//INT RETURN TYPE METHOD
	static int mul(int a,int b)
	{
	return a*b;	
	}
	//method overloading
	static double mul(double a,double b)
	{
		return a*b;
	}
	
	
	//MAIN
	static void Main(string[] args)
	{
		Method("Ali",12);
		Method("Amna",34);
		Method("Hamza",23);
		Method();
		MyMethod(child1:"Ali",child3:"Hamza",child2:"Hania");
		Console.WriteLine("MUL="+mul(5,4));
		Console.WriteLine("DOUBLE MUL="+mul(2345.23,872.321));
	}
}	
}