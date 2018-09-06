using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undervisning
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] skakBræt = new string[8, 8];
            skakBræt[0, 0] = "Ts";
            skakBræt[0, 1] = "Hs";
            skakBræt[0, 2] = "Ls";
            skakBræt[0, 3] = "Ds";
            skakBræt[0, 4] = "Ks";
            skakBræt[0, 5] = "Ls";
            skakBræt[0, 6] = "Hs";
            skakBræt[0, 7] = "Ts";

            for (int i = 0; i < 8; i++)
            {
                skakBræt[1, i] = "Bs";
                skakBræt[6, i] = "Bh";
                skakBræt[7, i] = skakBræt[0, i].Replace("s", "h");
            }

            for (int række = 0; række < 8; række++)
            {
                for (int kolonne = 0; kolonne < 8; kolonne++)
                {
                    Console.Write(skakBræt[række, kolonne] + " ");
                }
                Console.WriteLine();
                Console.ReadKey();
            }

        }
    }
}
