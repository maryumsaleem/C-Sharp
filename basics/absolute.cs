// C# Program to illlustrate the
// Math.Abs(Decimal) Method
using System;
  
class Geeks {
  
    // Main Method
    public static void Main()
    {
  
        // Taking decimal values
        decimal[] deci = {Decimal.MinValue, 45.14M, 0M,
                            -17.47M, Decimal.MaxValue};
  
        // using foreach loop
        foreach(decimal value in deci)
  
            // Displaying the result
            Console.WriteLine("Absolute value of {0} = {1}",
                                    value, Math.Abs(value));
    }
}