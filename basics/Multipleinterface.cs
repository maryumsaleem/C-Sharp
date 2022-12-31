using System;
interface Ifile
{
	//An interface can only contain declarations but not implementations. The following will give a compile-time error.
	void ReadFile();
}
interface IBinaryFile
{
	void OpenBinaryFile();
	void ReadFile();
}
class FileInfo : Ifile, IBinaryFile
{
	 void Ifile.ReadFile()
	{
		Console.WriteLine("Reading File");
	}
	
	  void IBinaryFile.OpenBinaryFile()
    {
        Console.WriteLine("Opening Binary File");
    }
	

    void IBinaryFile.ReadFile()
    {
        Console.WriteLine("Reading Binary File");
    }
	
	 public void Search(string text)
    {
        Console.WriteLine("Searching in file");
    }
}

public class program
{
	public static void Main(string[] args)
	{
		Ifile f1=new FileInfo();
		IBinaryFile file2=new FileInfo();
		FileInfo f3=new FileInfo();
		
		f1.ReadFile();
		file2.OpenBinaryFile();
        file2.ReadFile();
		//f1.WriteFile("content");
		//f2.ReadFile(); this will give error
		//f2.WriteFile("content"); this will give error
		
		f3.Search("text to be searched"); //its invoking class's own func not interface member
	}
}		
		
		/*
		Points to Remember :
1-Interface can contain declarations of method, properties, indexers, and events.
2-Interface cannot include private, protected, or internal members. All the members are public by default.
3-Interface cannot contain fields, and auto-implemented properties.
4-A class or a struct can implement one or more interfaces implicitly or explicitly. Use public modifier when implementing interface implicitly, whereas don't use it in case of explicit implementation.
5-Implement interface explicitly using InterfaceName.MemberName.
6-An interface can inherit one or more interfaces.
		*/