using System;
class test
{
	public static void Main()
	{
		char[] chars=new char[4];
		chars[0]='X';//chahracter literal
		chars[1]='\x0058';//Hexadecimal
		chars[2]=(char)88;//Cost from integral type
		chars[3]='\u0058';//Unicode
		
		foreach(char c in chars)
		{
			Console.WriteLine(c);
		}
	}
}