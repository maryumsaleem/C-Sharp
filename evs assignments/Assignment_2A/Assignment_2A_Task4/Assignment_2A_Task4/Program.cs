//Write a C# Sharp program that takes four numbers as input to calculate and 
//print the average
int num1,num2,num3,num4;
Console.WriteLine("Enter First Number:");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Second Number:");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Third Number:");
num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Fourth Number:");
num4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Averge={num1+num2+num3+num4/4}");
