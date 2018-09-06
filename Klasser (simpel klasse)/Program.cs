using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser__simpel_klasse_
{
    class Program
    {
        //Brug klassen i Main ved at skabe en 2-3 objekter med new og test at metoderne virker.


        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Fornavn = "Jesper";
            person1.Efternavn = "Hjarsen";
            person1.Fødselsår = 1982;

            Console.WriteLine(person1.Fuldtnavn());
            Console.WriteLine(person1.Alder());
            Console.ReadKey();

            Person person2 = new Person("Geden", "Iph", 1996);
            Console.WriteLine(person2.Fuldtnavn());
            Console.WriteLine(person2.Alder());
            Console.ReadKey();

            Console.Write("Du er dælme dygtig");
            Console.ReadKey();



        }


        //Du skal skabe en tom konsol app med en klasse Person med følgende medlemmer:

        class Person
        {
            //Et offentlig string felt kaldet Fornavn
            public string Fornavn;
            //Et offentlig string felt kaldet Efternavn
            public string Efternavn;
            //Et offentlig int felt kaldet Fødselsår
            public int Fødselsår;


            //En offentlig metode FuldtNavn() som returnerer Fornavn + ” ” + Efternavn
            public string Fuldtnavn()
            {
                return $"{Fornavn} {Efternavn}";
            }


            //En offentlig metode Alder() der beregner en estimeret alder ud fra fødselsår
            public int Alder()
            {
                int år = DateTime.Now.Year;
                return år - this.Fødselsår;
            }

            //En default constructor som sætter Fornavn og Efternavn til ””
            public Person()
            {
                this.Fornavn = "";
                this.Efternavn = "";

            }

            //En custom constructor som initialiserer alle felter
            public Person (string fornavn, string efternavn, int fødselsår)
            {
                this.Fornavn = fornavn;
                this.Efternavn = efternavn;
                this.Fødselsår = fødselsår;
      
            }
         
        


        }

         
    }
}
