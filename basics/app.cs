using sc=System.Console;
namespace abc{
	public class Hello{
		public static void Main(string[] args){
			sc.WriteLine("Enter your name:");
			string myName=System.Console.ReadLine();
			sc.WriteLine("Welcome :"+myName);
			sc.ReadKey();
		}
	}
}