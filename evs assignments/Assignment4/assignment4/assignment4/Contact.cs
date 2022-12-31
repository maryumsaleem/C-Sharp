using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    public class Contact
    {
        //Id, Name,CellNumer1, CellNumber2, Email, DateOfBirth and ContactGroup
        private int id;
        public int Id { get { return id; } set { id = value; } }

        private string? name;
        public string? Name 
        {
            get { return name; }
            set { name = value; }
        }

        private string? cellNumber1;

        public string? CellNumber1 
        {
            get {return cellNumber1;}
            set { cellNumber1 = value; }
        }
        //
        private string? cellNumber2;

        public string? CellNumber2
        {
            get { return cellNumber2; }
            set { cellNumber2 = value; }
        }

        private string? email;
        public string? Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }

            private string? dateOfBirth;
        public string? DateOfBirth 
         {
            get { return dateOfBirth;}
            set
            {
                dateOfBirth = value;
            }
         }

        private ContactGroup? contactGroup;

        public ContactGroup? ContactGroup 
        {
            get
            { return contactGroup; }
            set
            {
                contactGroup = value;
            }
        }

        public void Summary()
        {
           //string cn1= cellNumber1.ToString();
           // string cn2= cellNumber2.ToString();
            Console.WriteLine( $"{Name?.PadRight(30)}{CellNumber1?.PadRight(30)}{CellNumber2?.PadRight(30)}{ContactGroup?.Name?.PadRight(30)}");
        }
        
    }
    
}