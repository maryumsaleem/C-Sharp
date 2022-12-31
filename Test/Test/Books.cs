using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
     class Books
    {
        private int id;
        private string? tittle;
        private string? description;
        private string? author;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string? Tittle
        {
            get { return tittle; }
            set { tittle = value; }
        }

        public string? Description
        {
            get { return description; }
            set { description = value; }
        }
        public string? Author
        {
            get { return author; }
            set { author = value; }
        }
    }
    
}
