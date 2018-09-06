using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber__automatisk_egenskab_
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();
            p.Fornavn = "Jesper";
            p.Efternavn = "Hjarsen";

            Console.WriteLine(p.FuldtNavn());

            Console.ReadKey();


            Grævling a = new Grævling();
            a.Fornavn = "Hugo";
            a.Efternavn = "Ib";

            Console.WriteLine(a.Fuldtnavn());

            Console.ReadKey();


        }

        class Person
        {
            public string Fornavn { get; set; }

            private string efternavn;

            public string Efternavn
            {
                get { return efternavn; }

                set
                {
                    if (value.Length < 3)
                    {
                        efternavn = " ";

                    }
                    else
                    {
                        efternavn = value;
                    }

                }

            }

            public string FuldtNavn()
            {
                return Fornavn + " " + Efternavn;
            }

        }

        class Grævling
        {
            public string Fornavn { get; set; }


            private string efternavn;

            public string Efternavn
            {
                get { return efternavn; }

                set
                {
                    if (value.Length < 5)
                    {
                        efternavn = " ";
                    }
                    else
                    {
                        efternavn = value;
                    }

                }

            }

            public string Fuldtnavn()
            {
                return Fornavn + " " + Efternavn;
            }
        }
    }
}






