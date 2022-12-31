using System;
class Program
{
	public static void Main()
	{
	int Sum=0;
	int Product=0;
	calculate(5,2,out Sum,out Product);
	Console.WriteLine("sum={0},product={1}",Sum,Product);
	}
	//this "out" is used if you want to perfom two functionalities like sum and product with in same function but a function only return one value
	public static void calculate(int num1,int num2,out int sum,out int product)
	{
	sum=num1+num2;
	product=num1*num2;
	}
}