using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVS400
{
    public struct ContactNumber
    {
        private short countryCode;
        private short networkCode;
        private int number;

        public ContactNumber(short nc, int num) 
            : this(92,nc,num)
        {
           
        }

        public ContactNumber(short cc,short nc,int num)
        {
            countryCode = cc;
            networkCode = nc;
            number = num;
        }


        public short CountryCode { get => countryCode; }
        public short NetworkCode { get => networkCode; }
        public int Number { get => number; }

        public string FullNumber { get => $"+{countryCode}-{networkCode}-{number}"; }

        public bool IsStructCanHaveMethod()
        {
            //some code here
            return true;
        }


    }
}
