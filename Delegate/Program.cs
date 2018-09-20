using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{

    public delegate void MinDelegate1(string t);
    


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*");
            //MinDelegate1 f1 = new MinDelegate1(Console.WriteLine);
            //f1.Invoke("*");

            MinDelegate1 f1 = Console.WriteLine;
            f1 += MinSkriv;
            f1("*");

            f1 -= MinSkriv;
            f1 -= Console.WriteLine;
            

            Console.ReadKey();
        }

        static void MinSkriv(String txt)
        {
            Console.WriteLine("**** " + txt + " *****");

        }
        
                       
    }
}
