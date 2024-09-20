using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terulet
{
    internal class Program
    {
        static void terulet()
        {
            Console.WriteLine("Téglalap területének számítása");

            int a;
            int b;
            int T;

            do
            {
                Console.WriteLine("Kérem az 'a' oldal értékét. (0 > kell lennie)");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a <= 0);

            do
            {
                Console.WriteLine("Kérem az 'b' oldal értékét. (0 > kell lennie)");
                b = Convert.ToInt32(Console.ReadLine());
            } while (b <= 0);

            T = a * b;


            Console.WriteLine($"A téglalap területe {T}");

            Console.ReadKey();

        }
        
        static void Main(string[] args)
        {
            terulet();
        }
    }
}
