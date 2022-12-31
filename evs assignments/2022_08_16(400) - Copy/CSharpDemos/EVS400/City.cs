using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVS400
{
    public class City
    {
        private int id;

        public int Id
        {
            get { return id; } 
            set { id = value; }
        }
        private string? name;
        public string? Name
        {
            get { return name; }
            set { name = value; }
        }
        private Country? country;

        public Country? Country//name of the class and property can be same
        {
            get { return country; }
            set { country = value; }
        }
        public string Summary
        {
            get => $"{Id},{Name},{Country.Name}";
        }
    }
}
