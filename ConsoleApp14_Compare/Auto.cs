using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14_Compare
{
    class Auto: IComparable
    {
        public int Rocznik { get; set; }
        public string Marka { get; set; }

        public Auto(string mar, int r)
        {
            Marka = mar;
            Rocznik = r;
        }

        public int CompareTo(object obj)
        {
            var arg = (Auto)obj;

            if (Rocznik < arg.Rocznik)
                return 1;
            else if (Rocznik == arg.Rocznik)
                return 0;
            else
                return -1;
        }
    }
}
