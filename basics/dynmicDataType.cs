// C# program to illustrate how to get the
// actual type of the dynamic type variable
using System;
  
class GFG {
  
    // Main Method
    static public void Main()
    {
  
        // Dynamic variables
        dynamic val1 = "GeeksforGeeks";
        dynamic val2 = 3234;
        dynamic val3 = 32.55;
        dynamic val4 = true;
  
        // Get the actual type of
        // dynamic variables
        // Using GetType() method
        Console.WriteLine("Get the actual type of val1: {0}",
                                  val1.GetType().ToString());
  
        Console.WriteLine("Get the actual type of val2: {0}",
                                  val2.GetType().ToString());
  
        Console.WriteLine("Get the actual type of val3: {0}",
                                  val3.GetType().ToString());
  
        Console.WriteLine("Get the actual type of val4: {0}",
                                  val4.GetType().ToString());
    }
}