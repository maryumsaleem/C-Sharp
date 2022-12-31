using System;
using System.Globalization; //for CultureInfo.CurrentCulture
namespace app
{
	class program
	{
		static void Main(string[] args)
		{
			//assigns default value 01/01/0001 00:00:00
			DateTime dt1=new DateTime();
			Console.WriteLine(dt1);
			
			//assign year, month, day
			DateTime dt2=new DateTime(2022,06,09);
			Console.WriteLine(dt2);
			
			//assign year, month, day, hour, min, seconds
			DateTime dt3=new DateTime(2022,06,09,10,04,05);
			Console.WriteLine(dt3);
			
			//assign year, month, day, hour, min, seconds, UTC timezone
			DateTime dt4=new DateTime(2022,06,09,10,05,20,DateTimeKind.Utc);
			Console.WriteLine(dt4);
			
			//returns current date and time
			Console.WriteLine("Current");
			DateTime currentDateTime=DateTime.Now;
			Console.WriteLine(currentDateTime);
			
			// returns today's date
			Console.WriteLine("tODAY");
			DateTime todaysDate=DateTime.Today;
            Console.WriteLine(todaysDate);

			// returns current UTC date and time
			Console.WriteLine("UTC date and time");
            DateTime currentDateTimeUtc=DateTime.UtcNow;
			Console.WriteLine(currentDateTimeUtc);
			
			// returns max value of DateTime
			Console.WriteLine("max value of DateTime");
			DateTime maxDateTimeValue=DateTime.MaxValue;
			Console.WriteLine(maxDateTimeValue);
			
			// returns min value of DateTime
			Console.WriteLine("min value of DateTime");
             DateTime minDateTime=DateTime.MinValue;
			Console.WriteLine(minDateTime);
			
			//TimeSpan is used to get the interval between two DateTime values. You can get the interval difference in TimeSpan, Days, Hours, Minutes, Seconds, Milliseconds, Ticks.
			Console.WriteLine("TimeSpan");
			//Simple Object Creation with no parameters
			TimeSpan ts=new TimeSpan();
			Console.WriteLine(ts.ToString());//This creates an empty TimeSpan object with zero value.
			
			//By passing hours, minutes and seconds.
			TimeSpan ts1=new TimeSpan(23,10,10);
			Console.WriteLine(ts1);
			
			//By passing days, hours, minutes and seconds.
			TimeSpan ts2 = new TimeSpan(10, 23, 10, 10);
			Console.WriteLine(ts2);
			
			//By passing days, hours, minutes, seconds and milliseconds.
			TimeSpan ts3 = new TimeSpan(10, 23, 10, 10, 10);
			Console.WriteLine(ts3);
			
			//By passing number of ticks.
			Console.WriteLine("ticks");
			TimeSpan ts4 = new TimeSpan(100); 
			Console.WriteLine(ts4);
			
			DateTime startDateTime = DateTime.Now;  
            DateTime endDateTime = DateTime.Now.AddDays(10); 
            //var check="01-Nov-2015";			
            TimeSpan difference = endDateTime - startDateTime;  
			
            Console.WriteLine("Difference from \n {0} \n and \n {1} \n = \n  {2}",endDateTime,startDateTime, difference);  

			//Returns the day interval.
Console.WriteLine("Days = " + difference.Days);             
   
//Returns total interval in days.  
Console.WriteLine("Total Days = " + difference.TotalDays);             
   
//Returns hour interval leaving days.  
Console.WriteLine("Hours = " + difference.Hours);             
   
//Returns total interval in hours.  
Console.WriteLine("Total Hours = " + difference.TotalHours);  
   
//Returns the minute interval leaving hours and days.  
Console.WriteLine("Minutes = " + difference.Minutes);             
   
//Returns total interval in minutes.  
Console.WriteLine("Total Minutes = " + difference.TotalMinutes);         
   
//Returns the second interval leaving others.  
Console.WriteLine("Seconds = " + difference.Seconds);             
   
//Returns total interval in seconds.  
Console.WriteLine("Total Seconds =" + difference.TotalSeconds);             
   
//Returns the millisecond interval leaving others.  
Console.WriteLine("Milliseconds = " + difference.Milliseconds);  
   
//Returns total interval in milliseconds.  
Console.WriteLine("Total Milliseconds =" + difference.TotalMilliseconds);   
   
//Returns total number of ticks.  
//Ticks is basically Milliseconds * 10,000  
Console.WriteLine("Ticks = " + difference.Ticks);


//
			DateTime dt = new DateTime(2015, 12, 31);
		TimeSpan TS = new TimeSpan(25, 20, 55);
		
		DateTime newDate = dt.Add(TS);
		
		Console.WriteLine(newDate);
		//
		DateTime DT1 = new DateTime(2015, 12, 31);
		DateTime DT2 = new DateTime(2016, 2, 2);
		TimeSpan result = DT2.Subtract(DT1);
		Console.WriteLine(result);


//the DateTime struct overloads +, -, ==, !=, >, <, <=, >= operators to ease out addition, subtraction, and comparison of dates. These make it easy to work with dates.
Console.WriteLine("Operator overloading in DateTime");
DateTime t1 = new DateTime(2015, 12, 20);
		DateTime t2 = new DateTime(2016, 12, 31, 5, 10, 20);
		TimeSpan time = new TimeSpan(10, 5, 25, 50);
		
		Console.WriteLine(t2 + time); 
		Console.WriteLine(t2 - t1); 
		Console.WriteLine(t1 == t2);
		Console.WriteLine(t1 != t2);
		Console.WriteLine(t1 > t2); 
		Console.WriteLine(t1 < t2); 
		Console.WriteLine(t1 >= t2);
		Console.WriteLine(t1 <= t2);
		
		//We use DateTime.Parse to converts datetime strings into DateTime.
		Console.WriteLine("\nDateTime.Parse\n");
          string[] dates = {
                  "03/19/2021 07:20:58",
                  "03/19/2021",
                  "3/2021",
                  "3/21",
                  "4 AM",
                  "2021-03-19T05:20:12.0000000Z",
                  "2021-03-19T05:20:12.0000000-05:00",
                  "Fri, 19 Mar 2021 05:20:12 GMT",
                  "2021-03-19 05:20:12 -5:00",
};

foreach (var ds in dates)
{
    var tt = DateTime.Parse(ds);
    Console.WriteLine(tt);
}

//With DateTime.ParseExact, we explicitly specify the format of the datetime string.
Console.WriteLine("\nDateTime.ParseExact\n");
var dss = "Thu Nov 11, 2021";
var dtt = DateTime.ParseExact(dss, "ddd MMM dd, yyyy", CultureInfo.CurrentCulture);//The second parameter of the DateTime.ParseExact is the format of the datetime string. The third parameter is the culture.
Console.WriteLine(dtt);

var ds2 = "10-22-2015";
var dtt2 = DateTime.ParseExact(ds2, "MM-dd-yyyy", CultureInfo.CurrentCulture);
Console.WriteLine(dtt2);


//If the DateTime.Parse method fails, it throws a FormatException.

/*Console.WriteLine("\nFormatException\n");
string dsss = "03/19/2021";//"11/31/2021";

try
{
    DateTime dttt = DateTime.Parse(dsss);
    Console.WriteLine("{dt:d MMMM, yyyy}");
}
catch (FormatException e)
{
    Console.WriteLine("failed to parse string");
    Console.WriteLine(e.getMessage());
}*/

		}
	}
}