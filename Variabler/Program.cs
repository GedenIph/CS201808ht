using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            int _nummer;
            int _Nummer;
            int nummer;
            int AntaltMånederPrÅr;

            //Dette er den meste brugte standard
            int antalMaanederPrAar = 0;
            AntaltMånederPrÅr = 0;
            antalMaanederPrAar = antalMaanederPrAar + 1;

            System.Int32 a1 = 1;
            int a2 = 1;


            Console.WriteLine(a1);
            Console.WriteLine("a1 = " + a1);
            Console.WriteLine($"a1 = {a1}");

            int y = 10;

            // instans medlem
            Console.WriteLine(y.ToString());
            // statisk medlem
            Console.WriteLine(int.MaxValue);








            Console.ReadKey();

        }
    }
}
