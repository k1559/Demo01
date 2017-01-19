using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava6
{
    class Program
    {
        static void Main(string[] args)
        {
            double matka, hinta, bensankulutus;
            double bensanhinta = 1.595, kulutus = 7.02;
            Console.WriteLine("Anna matka");
            matka = int.Parse(Console.ReadLine());
            matka = matka / 100;
            bensankulutus = matka * kulutus;
            hinta = bensankulutus * bensanhinta;

            Console.WriteLine("Bensaa kuluu " + bensankulutus + " litraa, kustannus " + hinta + " euroa");

            Console.ReadLine();

        }
    }
}
