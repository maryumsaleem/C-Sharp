//Write a C# program to count a specified number in a given array of integer
Console.WriteLine("Enter a number");
int a=Convert.ToInt32(Console.ReadLine());
int[] arr = { 22,33,44,55,44,654,45,22,33,66,434,55};
Console.WriteLine($"Number of {a}present in the array:");
Console.WriteLine(arr.Count(n => n == a));
    