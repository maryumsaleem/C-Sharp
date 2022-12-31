//There is also a foreach loop, which is used exclusively to loop through elements in an array:
using System;
namespace app{
	public class app{
		static void Main(string[] args){
			int[] array={1,2,3,4};
			foreach(int i in array){
				Console.WriteLine(i);
			}
			//string array
			string[] array_s={"red","blue","green","black"};
			foreach(string i in array_s){
				Console.WriteLine(i);
			}
		}
	} 
}