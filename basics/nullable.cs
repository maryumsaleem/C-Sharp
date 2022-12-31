using System;
public class prgram
{
	static void Main(string[] args)
	{
		Nullable<int> i=null;
		myClass obj=new myClass();
		if(obj.i==null)
			Console.WriteLine("Null");
		//Use the '??' operator to assign a nullable type to a non-nullable type.
		int j=i ?? 9;
		//You can use the '?' operator to shorthand the syntax e.g. int?, long? instead of using Nullable<T>.
		double? D=null;
		Console.WriteLine("double="+D.GetValueOrDefault());
		//The HasValue returns true if the object has been assigned a value; if it has not been assigned any value or has been assigned a null value, it will return false.
		if(i.HasValue)
		{
			Console.WriteLine(i.Value);
		}
		else
		{
			Console.WriteLine("Null");
		}
		//Use the GetValueOrDefault() method to get an actual value if it is not null and the default value if it is null. For example:
		Console.WriteLine(i.GetValueOrDefault());
		Console.WriteLine(j);
		
		
		//Null is considered to be less than any value. So comparison operators won't work against null. Consider the following example where i is neither less than j, greater than j nor equal to j:
		if (i < j)
        Console.WriteLine("i < j");
    else if( i > 10)
        Console.WriteLine("i > j");
  

  else if( i == 10)
        Console.WriteLine("i == j");
    else
        Console.WriteLine("Could not compare");
	
	//Nullable static class is a helper class for Nullable types. It provides a compare method to compare nullable types. It also has a GetUnderlyingType method that returns the underlying type argument of nullable types.
	if (Nullable.Compare<int>(i, j) < 0)
			Console.WriteLine("i < j");
		else if (Nullable.Compare<int>(i, j) > 0)
			Console.WriteLine("i > j");
		else
			Console.WriteLine("i = j");
		
	}
}
	public class myClass
{
	public Nullable<int> i;
}


/*
Characteristics of Nullable Types
1-Nullable types can only be used with value types.
2-The Value property will throw an InvalidOperationException if value is null; otherwise it will return the value.
3-The HasValue property returns true if the variable contains a value, or false if it is null.
4-You can only use == and != operators with a nullable type. For other comparison use the Nullable static class.
5-Nested nullable types are not allowed. Nullable<Nullable<int>> i; will give a compile time error
*/

/*Points to Remember :
1-Nullable<T> type allows assignment of null to value types.
2-? operator is a shorthand syntax for Nullable types.
3-Use value property to get the value of nullable type.
4-Use HasValue property to check whether value is assigned to nullable type or not.
5-Static Nullable class is a helper class to compare nullable types.*/