using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv__simpel_
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person() { Efternavn = "Hjarsen", Fornavn = "Jesper" };
            Console.WriteLine("Person p fuldt navn");
            Console.WriteLine(p.Fuldtnavn());
            Console.ReadKey();

            Elev F = new Elev() { Efternavn = "Egon", Fornavn = "Lars", Klasselokale = "2" };
            Console.WriteLine("Elev F fuldtnavn");
            Console.WriteLine(F.Fuldtnavn());
            Console.ReadKey();

            Instruktør i = new Instruktør() { Efternavn = "Jensen", Fornavn = "Yvonne", NøgleId = 1 };
            Console.WriteLine("Instruktør i");
            Console.WriteLine(i.Fuldtnavn());
            Console.ReadKey();
        }
    }

    class Person
    {
        public string Fornavn { get; set; }

        public String Efternavn { get; set; }

        public string Fuldtnavn()
        {
            return $"{Fornavn + " " + Efternavn}";
        }

    }

    class Elev : Person
    {
        public string Klasselokale { get; set; }

    }

    class Instruktør : Person
    {
        public int NøgleId { get; set; }
               
    }
}
