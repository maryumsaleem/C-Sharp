/*In C#, IsNullOrEmpty() is a string method. 
It is used to check whether the specified string is null or an Empty string.
 A string will be null if it has not been assigned a value.
 A string will be empty if it is assigned “” or String.Empty (A constant for empty strings).*/
 
 /*
 Explanation: This method will take a parameter which is of type System.String and this method will returns a boolean value. If the str parameter is null or an empty string (“”) then return True otherwise return False.
 */
 
 /*
 Input : str  = null         // initialize by null value
        String.IsNullOrEmpty(str)
Output: True

Input : str  = String.Empty  // initialize by empty value
        String.IsNullOrEmpty(str)
Output: True
 */
 
 // C# program to illustrate 
// IsNullOrEmpty() Method
using System;
class Geeks {
    
    // Main Method
    public static void Main(string[] args)
    {
		string s0  = string.Empty;  // initialize by empty value
        
        string s1 = "GeeksforGeeks";
      
        // or declare String s2.Empty;
        string s2 = ""; 
  
        string s3 = null;
  
        // for String value Geeks, return false
        bool b1 = string.IsNullOrEmpty(s1);
  
        // For String value Empty or "", return true
        bool b2 = string.IsNullOrEmpty(s2);
  
        // For String value null, return true
        bool b3 = string.IsNullOrEmpty(s3);
		
		// for String.Empty (A constant for empty strings)
		bool b4=string.IsNullOrEmpty(s0);
  
        Console.WriteLine(b1);
        Console.WriteLine(b2);
        Console.WriteLine(b3);
		Console.WriteLine(b4);
    }
}