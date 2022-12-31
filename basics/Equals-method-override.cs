using System;
namespace Pragim
{
    public class MainClass
    {
        private static void Main()
        {
            Customer C1 = new Customer();
            C1.FirstName = "Simon";
            C1.LastName = "Tan";


            Customer C2 = new Customer();
            C2.FirstName = "Simon";
            C2.LastName = "Tan";


            Console.WriteLine(C1 == C2);
            Console.WriteLine(C1.Equals(C2));
        }
    }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public override bool Equals(object obj)
        {
            // If the passed in object is null
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Customer))
            {
                return false;
            }
            return (this.FirstName == ((Customer)obj).FirstName)
                && (this.LastName == ((Customer)obj).LastName);
        }


        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ LastName.GetHashCode();
        }
    }
}
