using System;

using ExtensionMethods;

public class Program
{
	public static void Main()
	{
		int i = 10;

        bool result = i.IsGreaterThan(100); 

		Console.WriteLine("Result: {0}",result);
	}
}

namespace ExtensionMethods
{
    public static class IntExtensions
     {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
}

/*Points to Remember :
1-Extension methods are additional custom methods which were originally not included with the class.
2-Extension methods can be added to custom, .NET Framework or third party classes, structs or interfaces.
3-The first parameter of the extension method must be of the type for which the extension method is applicable, preceded by the this keyword.
4-Extension methods can be used anywhere in the application by including the namespace of the extension method.*/
