using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EVS400.OnlineShop
{
    public class Category
    {
        private int id;
        private string? name;

        public int Id
        {
            get => id;
            set
            {
                id = value;
            }
        }

        public string? Name
        {
            get => name;
            set
            {
                name= value;
            }
        }
    }
}