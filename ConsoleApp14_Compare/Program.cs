using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14_Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto a1 = new Auto("Alfa", 1971);
            Auto a2 = new Auto("BMW", 1980);
            Auto a3 = new Auto("Citroen", 1966);
            Auto a4 = new Auto("Bugatti", 2019);
            Auto a5 = new Auto("Audi", 1975);

            List<Auto> autos = new List<Auto>();
            autos.Add(a1);
            autos.Add(a2);
            autos.Add(a3);
            autos.Add(a4);
            autos.Add(a5);

            autos.Sort(new AutoComparer());

            foreach (Auto item in autos)
            {
                Console.WriteLine(item.Rocznik + " - " + item.Marka);
            }

            Console.ReadKey();
        }
    }
}
