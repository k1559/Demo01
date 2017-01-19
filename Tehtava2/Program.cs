using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava2
{
    class Program
    {
        static void Main(string[] args)
        {
            int pisteet;
            Console.WriteLine("Anna pistemäärä ");
            pisteet = int.Parse(Console.ReadLine());

            switch (pisteet)
            {
                case 0: Console.WriteLine("Koulunumero on 0");break;
                case 1: Console.WriteLine("Koulunumero on 0");break;
                case 2: Console.WriteLine("Koulunumero on 1");break;
                case 3: Console.WriteLine("Koulunumero on 1"); break;
                case 4: Console.WriteLine("Koulunumero on 2"); break;
                case 5: Console.WriteLine("Koulunumero on 2"); break;
                case 6: Console.WriteLine("Koulunumero on 3"); break;
                case 7: Console.WriteLine("Koulunumero on 3"); break;
                case 8: Console.WriteLine("Koulunumero on 4"); break;
                case 9: Console.WriteLine("Koulunumero on 4"); break;
                case 10: Console.WriteLine("Koulunumero on 5"); break;
                case 11: Console.WriteLine("Koulunumero on 5"); break;
                case 12: Console.WriteLine("Koulunumero on 5"); break;

            }
            Console.ReadLine();
        }
    }
}
