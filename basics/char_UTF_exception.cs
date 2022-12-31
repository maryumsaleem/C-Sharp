// C# program to demonstrate
// Char.ConvertFromUtf32(Int32)
// Method
using System;
using System.Globalization;
 
class GFG {
 
    // Main Method
    public static void Main()
    {
        try {
 
            // declaring and initializing
            // int variable with 21 bit
            // unicode
            int utf = 0x11FFFF;
 
            // getting the value
            // using ConvertFromUtf32()
            Console.WriteLine("0x11FFFF is excedding the limit");
            string value = Char.ConvertFromUtf32(utf);
 
            // Display the value
            Console.WriteLine("value is {0}", value);
        }
        catch (ArgumentOutOfRangeException e) {
 
            Console.Write("Exception Thrown: ");
            Console.Write("{0}", e.GetType(), e.Message);
        }
    }
}