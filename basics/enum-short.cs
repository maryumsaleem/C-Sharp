//1-enums are strongly typed constnants.
//2-enums are used to replace set of integrals so that program can be more Readable and maintainable.
//2-enums are value types
//4-enums are enumerations
//5-enums are strongly typed constnants,an explicit cast is needed to convert from enum type to an integral type or vice versa.Also an enum of one type cn not be implicitly assigned to an enum of another type even though the underlying value of their members are the same.
//6-The default underlying type of an enum is int.
//7-The default value is Zero and incremented by 1.
//8- it is possible to customzied the underlying types and values.
//9-enum is used to create enumerations,Where as Enum class, contins stticGetValues() and GetNames() methods which can be used to list Enum underlying type values and Name.
using System;
public class Program
{
	public static void Main(string[] args)
	{
		//Gender gender=(Gender)Seasons.winter;
		short[] Values=(short[])Enum.GetValues(typeof(Gender));
		foreach(short v in Values)
		{
			Console.WriteLine(v);
		}
		string[] Names=Enum.GetNames(typeof(Gender));
		foreach(string n in Names)
		{
			Console.WriteLine(n);
		}
	}
}
public enum Gender:short
{
	Unkown=1,
	Male=2,
	Female=3
}
public enum Seasons
{
	summer,
	spring,
	winter
}