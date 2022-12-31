//3.Write a C# program to take name and age of two persons as input and show name of the elder person.
Console.WriteLine("Enter name of first person");
string name=Console.ReadLine();
Console.WriteLine("Enter age of first person");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("Enter name of second person");
string name1 = Console.ReadLine();
Console.WriteLine("Enter age of second person");
int age1 = int.Parse(Console.ReadLine());

if(age>age1)
{ 
    Console.WriteLine(name);
}
else
{
    Console.WriteLine(name1);
}