//Write a C# program remove specified a character from a non-empty string using index of a character
using System;
using System.Collections.Generic;

public class Exercise15 {
  static void Main(string[] args)
        {
			string s="w3resource";
			Console.WriteLine(s.Remove(5));
            Console.WriteLine(s.Remove(1,1));
            Console.WriteLine(s.Remove(9,1));
            Console.WriteLine(s.Remove(0,1));     
        }
      /* public static string remove_char(string st,int n)
        {
            return st.Remove(n,1);
        }*/
}