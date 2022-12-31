//Write a C# program to create a new string from a given string where the first 
//and last characters will change their positions
string? s;
Console.WriteLine("enter string:");
s=Console.ReadLine();
string s2 = s.Substring(0,1);//
string s3=s.Substring(s.Length-1);
string s4=s.Substring(1,s.Length-2);
Console.WriteLine($"{s3}{s4}{s2}");