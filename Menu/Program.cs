using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ohjelmassa on menu
            // 1 => tulostaa nimesi
            // 2 => kotikuntasi
            // 3 => suosikkibändisi
            // 0 => lopeta

            while (true)
            {
                Console.WriteLine("1 => tulostaa nimesi");
                Console.WriteLine("2 => tulostaa kotikuntasi");
                Console.WriteLine("3 => tulostaa lempibändisi");
                Console.WriteLine("0 => lopeta");
                int v = Convert.ToInt16(Console.ReadLine());
                if (v == 0) 
                    break;
                else if (v == 1)
                    Console.WriteLine("Kalle");
                else if (v == 2)
                    Console.WriteLine("Kokkola");
                else if (v == 3)
                    Console.WriteLine("NWA");
                else
                    Console.WriteLine("???");





            }

            // Program throws dice 100 times and tells amounts of different values (1, 2, 3, 4, 5, and 6).








            Console.Read();
        }
    }
}
