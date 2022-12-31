//2.Write a C# program to take temperature in degree Fahrenheit and convert it to degrees Centigrade (Celsius).

//Temp in Centigrade = (Temp in Fahrenheit - 32) *5 / 9
Console.WriteLine("Enter Temperature in degree Fahrenheit");
double TempinFahrenheit = double.Parse(Console.ReadLine());
double TempinCentigrade = (TempinFahrenheit - 32) * 5 / 9;
Console.WriteLine($"Temperture in degrees Centigrade (Celsius): {TempinCentigrade}");
