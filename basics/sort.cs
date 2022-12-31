using System;
using System.Linq;
namespace app{
	public class program{
		static void Main(string[] args){
			string[] colours={"red","blue","green","orange","yellow"};
			foreach(string i in colours){
				Array.Sort(colours);
				Console.WriteLine(i);
			}
			int[] numbers={23,45,8973,263};
			foreach(int i in numbers){
				Array.Sort(numbers);
				Console.WriteLine(i);
			}
				Console.WriteLine("max="+numbers.Max());
				Console.WriteLine("min="+numbers.Min());
				Console.WriteLine("SUM="+numbers.Sum());
		}
	}
}