using System;
interface Ifile
{
	//An interface can only contain declarations but not implementations. The following will give a compile-time error.
	void ReadFile();
	void WriteFile(string text);
}
class FileInfo : Ifile
{
	 void Ifile.ReadFile()
	{
		Console.WriteLine("Reading File");
	}
	 void Ifile.WriteFile(string text)
	{
		Console.WriteLine("Writting to File");
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
		FileInfo f2=new FileInfo();
		
		f1.ReadFile();
		f1.WriteFile("content");
		//f2.ReadFile(); this will give error
		//f2.WriteFile("content"); this will give error
		
		f2.Search("text to be searched"); //its invoking class's own func not interface member
	}
}		
		