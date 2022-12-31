using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVS400.OnlineShop
{
    public class Product
    {

        private static int counter;

        public static int Counter
        {
            get {
                //int x = this.id;
                return counter; 
            }
            //set { counter = value; }
        }

        private int id;

        public int Id
        {
            get {
                //int x = counter;
                return id; 
            }
            set { id = value; }
        }

        static Product()
        {
            counter = 500;
        }



        public Product()
        {
            counter++;
        }

        public Product(int id,string name,float costPrice) 
            : this()
        {
            Id = id;
            Name=name;
            CostPrice = costPrice;
        }

        public Product(int id, string name, float costPrice,float gstRate,string description) 
            : this(id,name,costPrice)  
        {
            GstRate= gstRate;
            Description = description;
        }


        public Product(Product product) 
            : this(product.Id,product.name,product.costPrice,product.gstRate,product.description)
        {
        }





        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        
        private float costPrice;

        public float CostPrice
        {
            get
            {
                return costPrice;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error");
                    return;
                }
                costPrice = value;
            }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private float gstRate;
        public float GstRate
        {
            get { return gstRate; }
            set { gstRate = value; }
        }

        private float profitMargin;
        public float ProfitMargin
        {
            get { return profitMargin; }
            set { profitMargin = value; }
        }

        public float GstAmount
        {
            get
            {
                return costPrice * GstRate /100;
            }
        }

        public float SalePrice
        {
            get { return costPrice + GstAmount + (costPrice * profitMargin/100); }
        }
        
        public string Summary
        {
            get { return $"{Name},{CostPrice},{GstAmount},{SalePrice}"; }
        }

      


    }
}
