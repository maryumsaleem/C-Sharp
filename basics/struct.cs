using System;
					
public class Program
{
	public static void Main()
	{
		//with new keyword
		Coordinate point = new Coordinate();
		
		Console.WriteLine(point.x); 
		Console.WriteLine(point.y); 
		//Create Structure Without new Keyword
		Coordinate point1;
		point1.x=12;
		Console.WriteLine(point1.x);
		
		//parameterized ctor
		Coordinate point2 = new Coordinate(10, 20);
		Console.WriteLine(point2.x); //output: 10  
		Console.WriteLine(point2.y); //output: 20  
		
		
	}
}

struct Coordinate
{
    public int x;
    public int y;
	// Static method names GFG
    static Coordinate()
    {
        Console.WriteLine("Hello! Static constructor is called");
    }
  
	public Coordinate(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

