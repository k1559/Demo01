using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava9
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku,luku2=0, summa;
            
            do
            {

                Console.WriteLine("Syötä luku");
                luku = int.Parse(Console.ReadLine());
                luku2 = luku2 + luku;
               

            } while (luku != 0);

            Console.WriteLine("Summa on " + luku2);
            Console.ReadLine();
        }
    }
}
