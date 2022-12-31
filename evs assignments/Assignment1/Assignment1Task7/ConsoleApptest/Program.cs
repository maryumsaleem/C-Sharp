using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            List<Product> lstProducts = new List<Product>();
        int increment = 1;
        for(int i=0;i<=4;i++)
        {
            lstProducts.Add(new Product());
            Console.WriteLine($"Enter name of the product {increment}");
            lstProducts[i].name = Console.ReadLine();
            Console.WriteLine($"Enter Cost of Product {increment}");
            lstProducts[i].costPrice = long.Parse(Console.ReadLine());
            

            lstProducts[i].salep = lstProducts[i].salesprice(lstProducts[i].costPrice);
            
            lstProducts[i].GST = lstProducts[i].Gst(lstProducts[i].salep);
            
            
           lstProducts[i].finalPrice = lstProducts[i].fp(lstProducts[i].salep, lstProducts[i].GST);
            increment++;
        }
        
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n Name                 Cost Price              Sale Price               GST                Final Price \n-------------------------------------------------------------------------------------------------------------\n");
           
        foreach (Product p in lstProducts)
            {
                Console.WriteLine(p.getData());
            }

        }
    }
class Product
{
    public string name;
    public long costPrice;
    public double salep;
    public double GST;
    public double finalPrice;

   public double salesprice(long cp)
    {
        double profit = (cp * 25) / 100;
        double sspp=cp+profit;
        return sspp;

    }
   public double fp(double sp, double g)
    {
        return sp + g;
    }
    public double Gst(double dd)
    {
        return dd * 17 / 100;
    }
    public string getData()
    {
        string namepad = name.PadRight(23);//use
       string scp= costPrice.ToString();
        string costpad =scp.PadRight(23);//use
        string ssp = salep.ToString();
        string salepad= ssp.PadRight(23);//use
        string sgst = GST.ToString();
        string gstpad = sgst.PadRight(23);//USE
        string sfp = finalPrice.ToString();
        string fppad = sfp.PadLeft(5);//use
        string print= " "+ namepad + costpad+ salepad+ gstpad+ fppad+"\n";
        return print;
    }
}