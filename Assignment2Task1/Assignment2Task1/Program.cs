//1. Take string and check if its palindrome 
string? s,s2="";
Console.WriteLine("Enter a string");
s=Console.ReadLine();
//tring? s2="";
int j = 0;
for (int i=s.Length-1; i>=0;i--)
{
    s2=s2+ s[i].ToString();   
}
if(s2==s)
{
    Console.WriteLine("string is palindrome");
}
else
{
    Console.WriteLine("String is not palindrome");
}