//Write a C# program to find the size of a specified file in bytes. Go to the editor

using System;
using System.Collections.Generic;
using System.IO;

public class Exercise29 {
 public static void Main() {
        FileInfo f = new FileInfo("C:\Users\Laulla\Desktop\c#");
        Console.WriteLine("\nSize of a file: "+f.Length.ToString());
 }
}