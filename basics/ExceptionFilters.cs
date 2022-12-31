using System;

public class Program
{
	public static void Main()
	{		
        Console.Write("Please enter a number to divide 100: ");
        
        try
        {
            int num = int.Parse(Console.ReadLine());

            int result = 100 / num;

            Console.WriteLine("100 / {0} = {1}", num, result);
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine("Cannot divide by zero. Please try again.");
        }
        catch(InvalidOperationException ex)
        {
            Console.WriteLine("Invalid operation. Please try again.");
        }
        catch(FormatException  ex)
        {
            Console.WriteLine("Not a valid format. Please try again.");
        }
        catch(Exception  ex)
        {
            Console.WriteLine("Error occurred! Please try again.");
        }
        
	}	
	
}

/*
Exception Filters:

You can use multiple catch blocks with the different exception type parameters. This is called exception filters. Exception filters are useful when you want to handle different types of exceptions in different ways.

Note: Multiple catch blocks with the same exception type are not allowed. A catch block with the base Exception type must be the last block.

Note:Multiple finally blocks are not allowed. Also, the finally block cannot have the return, continue, or break keywords. It doesn't let control to leave the finally block.
*/