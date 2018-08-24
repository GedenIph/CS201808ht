using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_enum
{
    //del 1
    enum Filtyper
    {   csv,
        pdf,
        txt
    }
    
    //del 2
    struct Person
    {
        public int id;
        public string Navn;

    }

    class Program
    {
        static void Main(string[] args)
        {

            //ENUM - del 1
            Console.WriteLine("tildeling af csv");
            Filtyper ft = ft = Filtyper.csv;
            Console.WriteLine(ft);
            Console.WriteLine((int)ft);

            Console.WriteLine("tildeling af pdf");
            Filtyper ft1 = ft1 = Filtyper.pdf;
            Console.WriteLine(ft1);
            Console.WriteLine((int)ft1);

            Console.ReadKey();

            //Struct - del 2

            Person p;
            p.id = 1;
            p.Navn = "Mikkel";
            Console.WriteLine(p.Navn);

            Console.ReadKey();



        }
    }
}
