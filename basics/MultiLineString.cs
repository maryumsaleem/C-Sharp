using System;
	 public class program
	    {
		   public static void Main(string[] args)
		     {
			string str1="this \n"+
			             "is \n"+
						 "multiLine\n"+
						 "string";
						
			Console.WriteLine(str1); 
			
		    string str2=@"this is a
			               multiLine
						   another
						   string";
			Console.WriteLine(str2);
		}		
	}