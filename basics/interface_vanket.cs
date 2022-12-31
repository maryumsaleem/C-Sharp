using System;
//there are no fields in the interface like in classes like int id etc.
interface ICustomer1
{
	void Print1();//there is no explicit access specifier in the member of interfaces they are public by defcult. if you put an access specifier then it will be a compike time error.
}
interface ICustomer2:ICustomer1
{
	void Print2();
}
public class Customer:ICustomer2
{
	public void Print1()
	{
		Console.WriteLine("ICustomer1 interface print method");
	}
	public void Print2()
	{
	   Console.WriteLine("ICustomer2 interface print method");
	}
}
public class Program
{
	public static void Main(string[] args)
	{
		Customer C1=new Customer();
		C1.Print1();
		C1.Print2();
		ICustomer1 cust=new Customer();//we cannot create an instace of an interface,but an interface reference variable can point to derived class object. here cust is interface reference variable and new customer(); is derived class object.
		cust.Print1();
		
	}
}