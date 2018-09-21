using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCronberg;

namespace Linq
{

    

    class Program
    {
        static void Main(string[] args)
        {

            var r = new PersonNuGetPackage.PersonRepositoryRandom();
            var people = r.GetPeople(100);
            foreach (var person in people)
                Console.WriteLine(person.Name);


            // Keep console open when debugging
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
