Console.WriteLine("Enter first Integer:");
int b = Convert.ToInt32(Console.ReadLine());
if (b > 0)
{
    Console.WriteLine(b % 3 == 0 || b % 7 == 0);
}