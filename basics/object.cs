using System;

namespace app
{
	//
	public class Program
	{
		//string color="red";
		int s=234;
		static void Main(string[] args)
		{
			app1.Car Tesla=new app1.Car();//obj of class car
			Program myobj=new Program();
			
			Tesla.name="Tesla";//field with value
			Tesla.color="black";
			Tesla.model="Model x";
			Console.WriteLine(Tesla.color);
			Console.WriteLine(Tesla.name);
			Console.WriteLine(Tesla.model);
			Tesla.fullThrottle();
			
			Console.WriteLine(myobj.s);
			
			//2nd object of class car
			app1.Car Ford=new app1.Car();
			Ford.model = "Mustang";
            Ford.color = "red";
            Ford.name = "Ford";
			
			Console.WriteLine(Ford.color);
			Console.WriteLine(Ford.name);
			Console.WriteLine(Ford.model);

		}
	}
}
//
namespace app1{
	public class Car
  {
    public string color;
	public string name;
	public string model;
	
	public Car()//ctor
	{
		color="grey";
		name="RR";
		model="1987";
	}
	pubblic Car(string c,string n,string m)//parameterized ctor
	{
		color=c;
		name=n;
		model=m;
	}
	
	 public void fullThrottle()    // method
    {
      Console.WriteLine("The car is going as fast as it can!");
    }

  }
	}