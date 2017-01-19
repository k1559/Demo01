using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava1
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            Console.Write("Anna luku");
            luku = int.Parse(Console.ReadLine());

            switch (luku)
            {
                case 1: Console.WriteLine("Annoit luvun yksi "); break;
                case 2: Console.WriteLine("Annoit luvun kaksi ");break;
                case 3: Console.WriteLine("Annoit luvun kolme ");break;
            }
            Console.ReadLine();

        }
    }
}
