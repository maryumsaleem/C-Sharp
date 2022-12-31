Console.WriteLine("1. Calculations Demo");
Console.WriteLine("2. Array Demo");
Console.WriteLine("3. String Demo");
Console.WriteLine("4. Date Demo");
Console.WriteLine("5. Exit");
int choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{ 
    case 1:
        Demo();
        break;
    case 2:
        ArrayDemo();
        break;
    case 3:
        StringDemo();
        break;
    case 4:
        DateDemo();
        break;
    default:
        exit();
        break;
}

void Demo()
{

}
//2. Array Demo
void ArrayDemo()
{
    string?[] names=new string[5];
    for(int i=0; i < names.Length; i++)
    {
        names[i]=Console.ReadLine();
    }
    Console.WriteLine("Original Data");
    foreach (var n in names)
    {
        Console.WriteLine(n);
    }
    Array.Sort(names);//for sorting names in array from a-z

    Console.WriteLine("\nSorted Data");
    foreach (var n in names)
    {
        Console.WriteLine(n);
    }
}


//3 String Demo
void StringDemo()
{
    string? temp = Console.ReadLine();
    if(temp!=null)
    {
        char c = temp[0];
        bool rr = char.IsDigit(c);

    }
}

void DateDemo()
{

}

void exit()
{
    Console.ReadKey();
}