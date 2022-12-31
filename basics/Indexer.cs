using System;
					
public class Program
{
	public static void Main()
	{
		StringDataStore strStore = new StringDataStore();

        strStore[0] = "One";
        strStore[1] = "Two";
        strStore[2] = "Three";
        strStore[3] = "Four";
        
        for(int i = 0; i < 10 ; i++)
            Console.WriteLine(strStore[i]);
	}
}

public class StringDataStore
{
    
    private string[] strArr = new string[10]; 

    public StringDataStore()
    {

    }

    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= strArr.Length)
                throw new IndexOutOfRangeException("Cannot store more than 10 objects");

            return strArr[index];
        }

        set
        {
            if (index < 0 || index >= strArr.Length)
                throw new IndexOutOfRangeException("Cannot store more than 10 objects");

            strArr[index] = value;
        }
    }
}

//Another syntex of indexer-> expression-bodied syntax for get and set

/*
using System;

public class Program
{
	public static void Main()
	{
		StringDataStore strStore = new StringDataStore();
		
		strStore[0] = "One";
		strStore[1] = "Two";
		strStore[2] = "Three";
		strStore[3] = "Four";
		
		for (int i = 0; i < 10; i++)
			Console.WriteLine(strStore[i]);
	}
}

class StringDataStore
{
	private string[] strArr = new string[10]; // internal data storage
	public string this[int index]
	{
		get => strArr[index];
		set => strArr[index] = value;
	}
}
*/

/*
C# indexers are usually known as smart arrays. A C# indexer is a class property that allows you to access a member variable of a class or struct using the features of an array. In C#, indexers are created using this keyword. Indexers in C# are applicable on both classes and structs. 
 
*/

/*
Important points to remember on indexers: 
1-Indexers are always created with this keyword.
2-Parameterized property are called indexer.
3-Indexers are implemented through get and set accessors for the [ ] operator.
4-ref and out parameter modifiers are not permitted in indexer.
5-The formal parameter list of an indexer corresponds to that of a method and at least one parameter should be specified.
6-Indexer is an instance member so can't be static but property can be static.
7-Indexers are used on group of elements.
8-Indexer is identified by its signature where as a property is identified it's name.
9-Indexers are accessed using indexes where as properties are accessed by names.
10-Indexer can be overloaded.
11-Indexer are defined in pretty much same way as properties, with get and set functions. The main difference is that the name of the indexer is the keyword this.
*/