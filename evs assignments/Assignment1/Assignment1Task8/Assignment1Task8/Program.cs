using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Employees> lstEmployees = new List<Employees>();
        int increment = 1;
        
        for (int i = 0; i <= 1; i++)
        {
            DateTime secondDate = DateTime.Now; //DateTime.Now;
            lstEmployees.Add(new Employees());
            Console.WriteLine($"Enter code of the employee {increment}");
            lstEmployees[i].code = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter name of the employee {increment}");
            lstEmployees[i].name = Console.ReadLine();
            Console.WriteLine($"Enter the joining date of employee {increment} like 05/29/2015");
            lstEmployees[i].joiningDate = DateTime.Parse(Console.ReadLine());

            lstEmployees[i].experience = lstEmployees[i].diff(lstEmployees[i].joiningDate, secondDate);

            increment++;
        }

        Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n Code                 Name                           Joining Date               Experience \n-------------------------------------------------------------------------------------------------------------\n");

        foreach (Employees e in lstEmployees)
        {
            Console.WriteLine(e.getData());
        }

    }
}
class Employees
{
    public int code;
    public string name;
    public DateTime joiningDate;
    public string experience;

public string diff(DateTime fd,DateTime sd)
    {
        int m1 = (sd.Month - fd.Month);//for years
        int m2 = (sd.Year - fd.Year) * 12; //for months
        Console.WriteLine(m1 + " " + m2);
        int months = m1 + m2;
        int years = sd.Year - fd.Year;
        string s = $"{years} years, {months} months";
        return s;
    }
    public string getData()
    {
        string cods = code.ToString();
        string codepad = cods.PadRight(23);//use
        string namepad = name.PadRight(23);//use
        string jd = joiningDate.ToString();
        string joindatepad= jd.PadRight(23);
        string exp = experience.PadRight(30);

        string print = " " + codepad + namepad  + joindatepad +exp+"\n";
        return print;
    }
}