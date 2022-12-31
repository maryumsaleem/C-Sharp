using System;

namespace spliterNS
{

	public class spliter
	{
		public static void Main(string[] args)
		{
			string s = "Hel0000l000000o";
			char third = s[2];
			string[] split = s.Split(third);
			//Console.WriteLine(split);
			foreach (var sp in split)
			{
				Console.WriteLine(sp);
			}
			Console.ReadKey();
		}
	}
}