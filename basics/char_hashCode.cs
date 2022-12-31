// C# program to demonstrate
// Char.GetHashCode() Method
using System;
  
class GFG {
  
    // Main Method
    public static void Main()
    {
  
        // declaring and initializing char
        char ch1 = 'B';
  
        // checking condition
        // using Equals() Method
        int val = ch1.GetHashCode();
  
        // Display Hashcode
        Console.WriteLine("Hashcode :- {0}", val);
    }
}