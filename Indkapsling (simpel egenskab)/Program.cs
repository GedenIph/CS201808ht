using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indkapsling__simpel_egenskab_
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare Øl = new Vare();
            Øl.Pris = 20;
            Øl.Navn = "Tuborg";

            Console.WriteLine(Øl.PrisMedMoms());

            Vare v2 = new Vare("vare #2", 200);
            Console.WriteLine(v2.PrisMedMoms());

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();
        }







        public class Vare
        {

            public Vare()
            {

            }

            public Vare(string navn, double pris)
            {
                this.Navn = navn;
                this.Pris = pris;

            }

            private string navn;
            public string Navn
            {
                get
                {
                    Console.WriteLine("Nu aflæses navn");
                    return navn;
                }

                set
                {
                    Console.WriteLine("Nu tildels navn");
                    navn = value;
                }

            }

            private double pris;
            public double Pris
            {
                get
                {
                    Console.WriteLine("Nu aflæses pris");
                    return pris;
                }

                set
                {
                    Console.WriteLine("Nu aflæses pris");
                    pris = value;
                }

            }

            public double PrisMedMoms()
            {
                return this.pris * 1.25;
            }



        }


    }
}
