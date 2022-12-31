/*17. Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back. Go to the editor
Sample Output:
Input a string : The quick brown fox jumps over the lazy dog.
TThe quick brown fox jumps over the lazy dog.T*/
using System;
class Program
{
	public static void Main(string[] args)
	{
		string str="The quick brown fox jumps over the lazy dog.";
		
		Console.WriteLine(str.Substring(0,1)+str+str.Substring(0,1));
	}
}