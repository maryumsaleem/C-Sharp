// C# program to demonstrate
// ToCharArray() method
using System;
class Geeks {
    
    // Main Method
    public static void Main()
    {
  
        String str = "GeeksForGeeks";
  
        // copy the string str to chars 
        // character array & it will start
        // copy from 'G' to 's', i.e. 
        // beginning to ending of string
        char[] chars = str.ToCharArray();
  
        Console.WriteLine("String: " + str);
        Console.Write("Character array :");
  
        // to display the resulted character array
        for (int i = 0; i < chars.Length; i++)
            Console.Write(" " + chars[i]);
    }
}