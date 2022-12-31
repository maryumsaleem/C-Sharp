// Write a C# Sharp program to swap two number
int a, b, temp;
Console.WriteLine("Enter First Number:");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Second Number:");
b = Convert.ToInt32(Console.ReadLine());
temp = a;
a = b;
b = temp;
Console.WriteLine("After Swapping");
Console.WriteLine($"First Number: {a}");
Console.WriteLine($"Second Number: {b}");
Console.ReadKey();