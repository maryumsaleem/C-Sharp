using System;
using System.Collections;//FOR ARRAYLIST
public class Program
{
	static void Main(string[] args)
	{
		var arlist=new ArrayList();
		arlist.Add(1);
		arlist.Add("Bill");
		arlist.Add(" ");
		arlist.Add(true);
		arlist.Add(4.5);
		arlist.Add(null);
		
		// adding elements using object initializer syntax
		var arlist1=new ArrayList()
		{
			2, "Steve", true, 4.5, null
		};
		Console.WriteLine("ArrayList  Elements");
		for(int i=0;i<arlist.Count;i++)
		{
			Console.WriteLine(arlist[i]);
		}
		Console.WriteLine("ArrayList 1 Elements");
			for(int i=0;i<arlist1.Count;i++)
		{
			Console.WriteLine(arlist1[i]);
		}
		
	}
}
