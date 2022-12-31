//Write a C# Sharp program that takes a number as input and print its multiplication table
        int n;
        Console.WriteLine("Enter the output number:");
        n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(n + "x" + i + "=" + n * i);
        }