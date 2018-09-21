using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCronberg;

namespace DynamikType
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic o = new { navn = "Jesper", alder = 36 };

            Console.WriteLine($"Personen hedder {o.navn} og er {o.alder} år gammel");

            dynamic o2 = new ExpandoObject();
            o2.navn = "Gurli Gris";
            o2.alder = 20;
            Console.WriteLine($"Personen hedder {o2.navn} og er {o2.alder} år gammel - expandoObject");
            SkrivPerson(o2);
           


            // Keep console open when debugging
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }


        static void SkrivPerson(dynamic obj)
        {
            Console.WriteLine($"Personer hedder {obj.navn} og er {obj.alder} år gammel - SkrivpersonMetode");
        }

    }









}
