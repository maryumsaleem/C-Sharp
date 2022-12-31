using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Task2
{
    class Product
    {
        private int code;
        private string? name;
        private float costPrice;
        private float gstRate;

        public int Code //property code
        { 
            get { return code; } 
            set {
                if (value < 0)//value is a keyword
                {
                    Console.WriteLine("error");
                }
                code = value; } 
        }
        public string? Name
        { 
            get { return name; }
            set 
            {
                if (value?.Length < 3 || value?.Length >50)//value is a keyword
                {
                    Console.WriteLine("error");
                }
                name = value; 
            }
        }

        public float CostPrice//property costPrice
        {
            get
            {
                return costPrice;
            }
            set 
            {
                if(value<0)//value is a keyword
                {
                    Console.WriteLine("error");
                }
                costPrice = value;
            }

        }
        public float GstRate
        {
            get => gstRate;
            set => gstRate=value;
        }
        public float GstAmmount// derived or calculated based property
        {
         get { return costPrice*gstRate/100; }
        }


        public float SalePrice//property
        {
            get { return costPrice + GstAmmount + costPrice * 0.25f; }
        }
    }

}

