using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava8
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2, luku3;
            Console.WriteLine("Anna luku");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna kolmas luku");
            luku3 = int.Parse(Console.ReadLine());

            if (luku1 > luku2 && luku1 > luku3) Console.WriteLine(luku1 + " on suurin");
            else if (luku2 > luku1 && luku2 > luku3) Console.WriteLine(luku2 + " on suurin");
            else if (luku3 > luku1 && luku3 > luku2) Console.WriteLine(luku3 + " on suurin");
          
        }
    }
}
