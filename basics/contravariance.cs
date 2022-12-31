/*Contravariane is applied to parameters. Cotravariance allows a method with the parameter of a base class to be assigned to a delegate that expects the parameter of a derived class.*/
using System;
delegate Small covarDel(Big mc);

class Program
{
    static Big Method1(Big bg)
    {
        Console.WriteLine("Method1");
        return new Big();
    }
    static Small Method2(Big bg)
    {
        Console.WriteLine("Method2");
        return new Small();
    }

    static Small Method3(Small sml)//contravariance
    {
        Console.WriteLine("Method3");
        
        return new Small();
    }
    static void Main(string[] args)
    {
        covarDel del = Method1;
        del += Method2;
        del += Method3;

        Small sm = del(new Big());
}