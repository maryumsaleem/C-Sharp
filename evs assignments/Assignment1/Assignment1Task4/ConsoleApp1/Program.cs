//4.Write a C# program to take student's roll number, student's name and his marks in programming test as input from console and calculate his grade based on following criteria.
//A 90% and above
//B 80% and bellow 90%
//C 70% and bellow 80%
//D 60% and bellow 70%
//F bellow 60%
Console.WriteLine("Enter Student's Name");
string name =Console.ReadLine();
Console.WriteLine("Enter Student's Roll Number");
int rollNo = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Student's Marks in programming test");
int marks = int.Parse(Console.ReadLine());
double percentge = (marks / 100) * 100;
if (percentge == 90|| percentge > 90)
{
    Console.WriteLine("A");
}
else if (percentge < 90|| percentge == 80)
{
    Console.WriteLine("B");
}
else if (percentge < 80||percentge == 70)
{
    Console.WriteLine("C");
}
else if (percentge==60||percentge<70)
{
    Console.WriteLine("D");
}
else if (percentge<60)
{
    Console.WriteLine("F");
}


