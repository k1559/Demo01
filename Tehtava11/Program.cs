using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava11
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            Console.WriteLine("Kuinka monta tähteä haluat? ");
            luku = int.Parse(Console.ReadLine());

            for (int i= 0; i<luku ; i++) Console.WriteLine("*");
            Console.ReadLine();
        }
    }
}
