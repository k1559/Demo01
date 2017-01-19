using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava7
{
    class Program
    {
        static void Main(string[] args)
        {
            int vuosi, karkaus, sata;
            Console.WriteLine("Anna vuosi");
            vuosi = int.Parse(Console.ReadLine());
            karkaus = vuosi % 4;
            sata = vuosi % 400;


          if ( karkaus ==0 && vuosi % 100 != 0)
            {
                Console.WriteLine("Vuosi on karkausvuosi");
            }
          else if (karkaus == 0 && vuosi % 400 == 0)
            {
                Console.WriteLine("Vuosi on karkausvuosi");
            }
          else
            {
                Console.WriteLine("Vuosi ei ole karkausvuosi");
            }
            
            Console.ReadLine();
        }
    }
}
