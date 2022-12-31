using System;
using System.Collections.Generic;
public class Exercise28 {
 public static void Main() {
  string line;
  line=Console.ReadLine();

  Console.WriteLine("\nOriginal String: " + line);
  string result = "";
  List < string > wordsList = new List < string > ();
  string[] words = line.Split(new [] { " "}, StringSplitOptions.None);
 // Console.WriteLine(words.Length+words[7]);
  
  for (int i = words.Length - 1; i >= 0; i--) {
   //result += words[i] + " ";
   result=result+words[i] + " ";
  }
  //adding in list
  wordsList.Add(result);
  //displaying list
  foreach(string s in wordsList) {

   Console.WriteLine("\nReverse String: " + s);
  }
 }
}
