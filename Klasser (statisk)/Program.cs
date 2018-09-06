using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser__statisk_
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = Beregninger.Lægsammen(1, 2);
            Console.WriteLine(res);
            Console.ReadKey();

            int minus = Beregninger.TrækFra(7, 2);
            Console.WriteLine(minus);
            Console.ReadKey();

           
        }

        class Beregninger
        {
            public static int Lægsammen(int a, int b)
            {
                return a + b;
            }
            
            public static int TrækFra(int a, int b)
            {
                return a - b;
            }

            private Beregninger()
            {


            }

        }
                       
    }
}
