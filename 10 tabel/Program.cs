using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_tabel
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int y = 1; y < 11; y++)
                {
                    string tal = (i * y).ToString();
                    if ((i * y) > 50)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(tal.PadLeft(4));
                }
                Console.WriteLine();
            }

            Console.ReadKey();





        }
    }
}
