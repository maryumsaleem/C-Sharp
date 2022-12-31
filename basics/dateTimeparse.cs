//The following code will calculate months between two dates:
using System;
using System.Globalization; //for CultureInfo.CurrentCulture
namespace app
{
	class program
	{
		static void Main(string[] args)
		{
		//First Date
		Console.WriteLine("Enter Date like 05/29/2015");
            DateTime firstDate =DateTime.Parse(Console.ReadLine());
 
            //Second Date
            DateTime secondDate =DateTime.Now; //DateTime.Now;
 
            int m1 = (secondDate.Month - firstDate.Month);//for years
            int m2 = (secondDate.Year - firstDate.Year) * 12; //for months
			Console.WriteLine(m1+" "+m2);
            int months = m1 + m2;
			int years=secondDate.Year - firstDate.Year;
 
 
            Console.WriteLine("First Date  :"+firstDate);
            Console.WriteLine("Second Date :" + secondDate);
            Console.WriteLine("Months      :"+months);
			Console.WriteLine("Years       :"+years);
            Console.ReadLine();
	}
}
}
/*
	string dateString, format;
      DateTime result;
      CultureInfo provider = CultureInfo.InvariantCulture;
			// Parse date and time with custom specifier.
      dateString = "Sun 15 Jun 2008 8:30 AM -06:00";
      format = "ddd dd MMM yyyy h:mm tt zzz";
      try {
         result = DateTime.ParseExact(dateString, format, provider);
         Console.WriteLine("{0} converts to {1}.", dateString, result.ToString());
      }
      catch (FormatException) {
         Console.WriteLine("{0} is not in the correct format.", dateString);
      }
*/