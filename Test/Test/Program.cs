using System.Diagnostics;
using Test;

//Console.WriteLine("ADD books");
//Console.WriteLine("to Display books");
//int num;
//num= Convert.ToInt32(Console.ReadLine());
int n;
Console.WriteLine($"Enter the number of books you want to Add:");
n = Convert.ToInt32(Console.ReadLine());

Books[] books = new Books[n];
        
        int j = 1;
        for (int i = 0; i < books.Length; i++)
        {
            Books b = new Books();
            Console.WriteLine($"Enter id of book {j}:");
            b.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Tittle of Book:");
            b.Tittle = Console.ReadLine();
            Console.WriteLine("Enter the description of Book:");
            b.Description = Console.ReadLine();
            Console.WriteLine("Enter the Author of Book:");
            b.Author = Console.ReadLine();

            books[i] = b;
            j++;
        }
        Console.Clear();
        foreach (Books b in books)
        {
            Console.WriteLine($"Id:{b.Id}\nTittle:{b.Tittle}\nDescription{b.Description}\nAuthor:{b.Author}\n");
        }

