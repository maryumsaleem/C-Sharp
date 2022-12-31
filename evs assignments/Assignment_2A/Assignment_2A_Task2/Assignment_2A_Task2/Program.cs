//Write a C# Sharp program to print on screen the output of adding, 
//subtracting, multiplying and dividing of two numbers which will be entered 
//by the user
int num1;
int num2;
Console.WriteLine("Enter first number");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter first number");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum={num1 + num2}");
Console.WriteLine($"Subtraction={num1 - num2}");
Console.WriteLine($"Multiplication={num1*num2}");
Console.WriteLine($"Division={num1/num2}");