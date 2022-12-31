using System;
class Program
{
	public static void Main(string[] args)
	{
		int num1;
		int num2;
		int a=2;
		int sub,mul;
		float div;
		Console.WriteLine("Enter first number:");
		num1=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter second number:");
		num2=Convert.ToInt32(Console.ReadLine());
		
		//call
		parameter(num1,num2,ref a,out sub,out mul,out div);
		
		Console.WriteLine("\n\n{0}+{1}={2}",num1,num2,a);
		Console.WriteLine("{0}-{1}={2}",num1,num2,sub);
		Console.WriteLine("{0}-{1}={2}",num1,num2,mul);
		Console.WriteLine("{0}-{1}={2}",num1,num2,div);
	}
	//"ref" tells the compiler that the object is initialized before entering the function,
	//while "out" tells the compiler that the object will be initialized inside the function.
	
	//So while "ref" is two-way, out is one way.
	public static void parameter(int num1,int num2,ref int a,out int sub,out int mul,out float div)
	{
		a=num1+num2;
		sub=num1-num2;
		mul=num1*num2;
		div=(float)num1/num2;
	}	
}