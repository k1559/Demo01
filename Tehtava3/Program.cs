using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava3
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2, luku3, summa, keskiarvo;
            Console.WriteLine("Anna luku ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna kolmas luku ");
            luku3 = int.Parse(Console.ReadLine());

            summa = luku1 + luku2 + luku3;
            Console.WriteLine("Summa on " + summa);
            keskiarvo = summa / 3;
            Console.WriteLine("Keskiarvo on " + keskiarvo);

            Console.ReadLine();
        }
     
    }
}
