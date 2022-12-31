using System;
namespace app1
{
	class main{
	static void Main(string[] args)
	{
		try
		{
			int[] myNumbers={1,2,3};
			Console.WriteLine(myNumbers[10]);
		}
		catch(Exception e)
		{
			Console.WriteLine(e.Message);
		}
		 finally
      {
        Console.WriteLine("The 'try catch' is finished.");
      }  
	}
 }
}