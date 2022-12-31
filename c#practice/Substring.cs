/*
Q:Write a C# program to create a new string from a given string where the first and last characters will change their positions. Go to the editor
Test Data:
w3resource
Python
Sample Output:
e3resourcw
nythoP
x
*/
using System;
using System.Collections.Generic;

public class Exercise16 {
  static void Main(string[] args)
        {
            Console.WriteLine(first_last("w3resource"));
            Console.WriteLine(first_last("Python"));
            Console.WriteLine(first_last("x"));
        }
       public static string first_last(string ustr)
        {
            return ustr.Length > 1//if
                ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;//else
        }
}
