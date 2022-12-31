using System;
using PATA=ProjectA.TeamA; //namespace Alias
using PATB=ProjectA.TeamB;
class Program
{
	public static void Main()
	{
PATA.ClassA.Print();
PATB.ClassA.Print();
	}
	
}
namespace ProjectA
{
	namespace TeamA
	{
		class ClassA
		{
			public static void Print()
			{
			Console.WriteLine("it is class A Print method");
			}
		}
	}
}
//
namespace ProjectA
{
	namespace TeamB
	{
		class ClassA
		{
			public static void Print()
			{
			Console.WriteLine("it is class B Print method");
			}
		}
	}
}