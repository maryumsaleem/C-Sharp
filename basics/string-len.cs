using System;
namespace App
{
	public class Program
	{
		public static void Main(string[] args)
		{
			string s="i am maryum";
			string fname="maryum";
			string lname="saleem";
			string name=fname+lname;
			string name1=string.Concat(fname,lname);
			//string interpolation
			//string name2= ($"My full name is: {fname} {lname}");
			Console.WriteLine("lenght of string:"+s.Length);
			Console.WriteLine(s.ToUpper());
			Console.WriteLine(s.ToLower());
			Console.WriteLine(name);
			Console.WriteLine("conat func: "+name1);
			//Console.Write.Line($"My full name is:, {fname} {lname}");
			Console.WriteLine(fname[2]);
			Console.WriteLine(lname.IndexOf("e"));
			string sub=lname.Substring(lname.IndexOf("e"));
			Console.WriteLine(sub);
			string txt = "We are the so-called \"Vikings\" from the north.";
      Console.WriteLine(txt);
	  string txt1 = "It\'s alright.";
      Console.WriteLine(txt1);
	  string txt2 = "The character \\ is called backslash.";
      Console.WriteLine(txt2);
	  string txt3 = "Hel\blo World!";
      Console.WriteLine(txt3);
	
		}
	}
}