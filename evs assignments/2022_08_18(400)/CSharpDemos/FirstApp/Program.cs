using EVS400;

//Country pk=new Country();
//pk.Id = 1;
//pk.Name = "Pakistan";
//pk.Code = 92;

//City c1 = new City();
//c1.Id = 1;
//c1.Name = "Lahore";
//c1.Country = pk;

//City c2 = new City();
//c2.Id = 2;
//c2.Name = "Karachi";
//c2.Country = pk;


Country[] countries = { 
    new Country{ Id=1, Name="Pakistan", Code=92},
    new Country{ Id=2, Name="China", Code=86}
};

City[] cities = new City[3];

for (int i = 0; i < cities.Length; i++)
{
    City c = new City();

    Console.WriteLine("Enter city id: ");
    c.Id = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter city name: ");
    c.Name = Console.ReadLine();

    Console.WriteLine("Select country:");
    for (int j = 0; j < countries.Length; j++)
    {
        Console.WriteLine($"{j} -> {countries[j].Name}");
    }
    Console.Write(">");
    int index = Convert.ToInt32(Console.ReadLine());
    c.Country = countries[index];

    cities[i] = c;
}

foreach (var c in cities)
{
    Console.WriteLine(c.Summary);
}





Console.ReadLine();

