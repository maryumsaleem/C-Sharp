using System;
public struct Customer
{
	private int id;
	private string name;
	 
	public string Name
	{
		get{return this.name;}
		set{this.name=value;}
	}
	public int Id
	{
		get{return this.id;}
		set{this.id=value;}
	}
	public Customer(int id,string name)
	{
		this.id=id;
		this.name=name;
	}
	public void Print()
	{
		Console.WriteLine("Id={0} && Name={1}",this.id,this.name);
	}
}
class Program
{
  public static void Main()
  {
	Customer c1=new Customer(101,"Mark");
	c1.Print();
	
	Customer c2=new Customer();
	c2.Id=102;
	c2.Name="John";
	c2.Print();
	
	//object initializer
	Customer c3=new Customer
	{
		Id=103
		Name="Robo"
	};
	c3.Print();
	
  }
}