using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays__simpel_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] månedsløn = { 10000, 20000, 15000, 20000, 30000, 15000 };
            double sum = 0;
            for (int i = 0; i < månedsløn.Length; i++)
            {
                sum += månedsløn[i];
                Console.WriteLine(månedsløn[i]);
                
            }
            Console.Write("Månedsløn sammenlagt = ");
            Console.WriteLine(sum);
            Console.ReadKey();


            double gns = sum / månedsløn.Length;
            Console.WriteLine("Gennemsnit " + gns.ToString("N2"));
            
            Console.ReadKey();
        }

        
    }

}
