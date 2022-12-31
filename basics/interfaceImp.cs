using System;
public class program
{
	static void Main(string[] args)
	{
		Ifile f1=new FileInfo();
		FileInfo f2=new FileInfo();
		
		f1.ReadFile();
		f1.WriteFile("content");
		
		f2.ReadFile();
		f2.WriteFile("content");
	}
}
interface Ifile
{
	//An interface can only contain declarations but not implementations. The following will give a compile-time error.
	void ReadFile();
	void WriteFile(string text);
}
class FileInfo : Ifile
{
	public void ReadFile()
	{
		Console.WriteLine("Reading File");
	}
	public void WriteFile(string text)
	{
		Console.WriteLine("Writting to File");
	}
}		
		