using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates__beregner_
{

    public delegate int Beregn(int a, int b);


    class Program
    {
        static void Main(string[] args)
        {

            Beregn Jesper = new Beregn(Plus);
            int res = Beregner(3, 4, Jesper);
            Console.WriteLine(res);

            Beregn Hjarsen = new Beregn(Minus);
            int res2 = Beregner(9, 4, Hjarsen);
            Console.WriteLine(res2);

            Beregn geden = new Beregn(Divider);
            int res3 = Beregner(100, 4, geden);
            Console.WriteLine(res3);

            var f = FindTilfældigFunktion();
            int res4 = f(5, 5);
            Console.WriteLine("res 4 svar = ");
            Console.WriteLine(f);
            Console.WriteLine(res4);

            Console.ReadKey();
        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Divider(int a, int b)
        {
            return a / b;
        }

        public static int Gange(int a, int b)
        {
            return a * b;
        }

        public static int Beregner(int a, int b, Beregn funktion)
        {
            return funktion(a, b);
        }

        public static Beregn FindTilfældigFunktion()
        {
            if (System.DateTime.Now.Millisecond <= 250)
                return Plus;
            if (System.DateTime.Now.Millisecond <= 500)
                return Minus;
            if (System.DateTime.Now.Millisecond <= 750)
                return Gange;

            return Divider;

        }
    }
}
