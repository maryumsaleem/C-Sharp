// C# program to illustrate the
// Char.IsWhiteSpace(Char) Method
using System;
  
class GFG {
  
    // Main Method
    static public void Main()
    {
  
        // Declaration of data type
        bool output;
  
        // checking if space
        // is a whitespace
        char c1 = ' ';
        output = Char.IsWhiteSpace(c1);
        Console.WriteLine(output);
  
        // checking if carriage return
        // is a whitespace
        char c2 = '\n';
        output = Char.IsWhiteSpace(c2);
        Console.WriteLine(output);
  
        // checking if hyphen
        // is a whitespace
        char c3 = '-';
        output = Char.IsWhiteSpace(c3);
        Console.WriteLine(output);
    }
}