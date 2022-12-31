// C# program to demonstrate the
// Char.CompareTo(Char) Method
using System;
class GFG {
  
    // Main Method
    public static void Main()
    {
        char c1 = 'G';
        char c2 = 'f';
        char c3 = 'M';
		/*
		The return value is zero if the current instance has the same position in the sort order as Val. It’s less than zero if the current instance is less than Val. The return value is greater than zero if the current instance follows Val.
		
		char val = 'A';
      Console.WriteLine("Return Value = "+'A'.CompareTo(val));
		*/
  
        // using Char.CompareTo(Char) Method
        // returns 0 as this instance has
        // same position in the sort as in c1
        Console.WriteLine('G'.CompareTo(c1));
  
        // using Char.CompareTo(Char) Method
        // returns -31 as this instance
        // precedes c2
        Console.WriteLine('G'.CompareTo(c2));//G<f
  
        // using Char.CompareTo(Char) Method
        // returns -6 as this instance follows
        // c3
        Console.WriteLine('G'.CompareTo(c3));
		
		Console.WriteLine('H'.CompareTo(c1));
    }
}