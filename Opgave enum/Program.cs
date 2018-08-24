using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_enum
{
    enum Filtyper
    {   csv,
        pdf,
        txt
    }
    
    struct Person
    {
        public int id;
        public string Navn;

    }

    class Program
    {
        static void Main(string[] args)
        {

            //ENUM
            Console.WriteLine("tildeling af csv");
            Filtyper ft = ft = Filtyper.csv;
            Console.WriteLine(ft);
            Console.WriteLine((int)ft);

            Console.WriteLine("tildeling af pdf");
            Filtyper ft1 = ft1 = Filtyper.pdf;
            Console.WriteLine(ft1);
            Console.WriteLine((int)ft1);

            Console.ReadKey();

            //Struct

            Person p;
            p.id = 1;
            p.Navn = "Mikkel";
            Console.WriteLine(p.Navn);

            Console.ReadKey();



        }
    }
}
