using System;
class Program
{
	public static void Main(string[] args)
	{
		// Taking a string
        String str = "Geeks, For Geeks";
		string[] spearator={"s, ","For"};
		int count=2;
		//using the method
		String[] strlist=str.Split(spearator,count,StringSplitOptions.RemoveEmptyEntries);
		foreach(String s in strlist)
		{
			Console.WriteLine(s);
		}
	}
}
