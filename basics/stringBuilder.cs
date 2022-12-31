using System;
using System.Text;
public class program
{
	public static void Main()
	{
		StringBuilder sb=new StringBuilder("Hello World!!",50);
		//Use the AppendFormat() method to format an input string into the specified format and append it.
		StringBuilder amountMsg = new StringBuilder("Your total amount is ");
		
		amountMsg.AppendFormat("{0:C} ", 25);
		
		Console.WriteLine(amountMsg);
//The StringBuilder is not the string. Use the ToString() method to retrieve a string from the StringBuilder object.
	var greet = sb.ToString(); //returns "Hello World!"
		Console.Write("greet:"+greet+"\n");
		
		//Use the Append() method to append a string at the end of the current StringBuilder object. If a StringBuilder does not contain any string yet, it will add it. The AppendLine() method append a string with the newline character at the end.
		sb.Append("from my side!!");
		sb.AppendLine("Hello C#!");
		sb.AppendLine("This is new line.");
		
		
		Console.WriteLine(sb);
		
		Console.WriteLine(sb);
		for(int i=0;i<=sb.Length;i++)
		{
			Console.Write(sb[i]);
		}

		
		
	
		
	}
}
/*Points to Remember :
1-StringBuilder is mutable.
2-StringBuilder performs faster than string when appending multiple string values.
3-Use StringBuilder when you need to append more than three or four strings.
4-Use the Append() method to add or append strings to the StringBuilder object.
5-Use the ToString() method to retrieve a string from the StringBuilder object.*/