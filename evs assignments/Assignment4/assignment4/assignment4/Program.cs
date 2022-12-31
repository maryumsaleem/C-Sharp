
using assignment4;

ContactGroup[] arr ={
    new ContactGroup{ Id=1,Name="Teacher"},
    new ContactGroup{Id=2,Name="Friend" }
};

Contact[] arr1 = new Contact[5];

for(int i=0;i<arr1.Length;i++)
{
    Contact c=new Contact();
    Console.WriteLine("Enter your Id:");
    c.Id = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter your Name:");
    c.Name = Console.ReadLine();

    Console.WriteLine("Enter your Cell Number 1:");
    c.CellNumber1 = Console.ReadLine();


    Console.WriteLine("Enter your Cell Number 2:");
    c.CellNumber2 =Console.ReadLine();

    Console.WriteLine("Enter your Email:");
    c.Email = Console.ReadLine();

    Console.WriteLine("Enter your Date of Birth:");
    c.DateOfBirth =Console.ReadLine();

    Console.WriteLine("Select Group");
    for (int j=0;j<arr.Length;j++)
    {
        Console.WriteLine($"Chose Group:{j}->{arr[j].Name}");
    }
    Console.Write(">");
    int index = Convert.ToInt32(Console.ReadLine());
    c.ContactGroup = arr[index];

    arr1[i] = c;
}

Console.WriteLine("-------------------------------------------------------------------------------------------------------------\nName                           Cell Number1               Cell Number2                   Group \n-------------------------------------------------------------------------------------------------------------\n");
foreach (var c in arr1 )
{
    c.Summary();
}

Console.ReadKey();