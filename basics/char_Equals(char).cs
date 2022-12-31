// C# program to illustrate the
// Char.Equals(Char) Method
using System;
  
public class GeeksforGeeks {
  
    // Main method
    public static void Main() 
	{
  
        // declaration of datatype
        bool result;
        char ch1 = 'G';
  
        // checking if 'G' is equal or not
  
        // Here we are passing char G as the
        // parameter to the Equals Method
        result = ch1.Equals('G');
  
        Console.WriteLine(result);    
          
        // checking if 'v' is equal or not
        char ch2 = 'v';
  
        // Here we are passing char W as the
        // parameter to the Equals Method
        result = ch2.Equals('W');
  
        Console.WriteLine(result);
    }
}