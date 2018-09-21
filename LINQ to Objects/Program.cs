using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_to_Objects
{
    class Program
    {
        static void Main(string[] args)
        {

            var r = new PersonNuGetPackage.PersonRepositoryRandom();
            var people = r.GetPeople(10);
            foreach (var person in people)
                Console.WriteLine(" hent 10 personer " + person.Name);


            // Sorter og udskriv efter navn og udskriv igen
            var res1 = from person 
                       in people
                       orderby person.Name
                       select person;
                foreach (var person in res1)
                Console.WriteLine("hent navn og sorter alfabetisk " + person.Name);

            // Sorter og udskriv efter gender og så navn
            var res2 = from person
                       in people
                       orderby person.Gender, person.Name
                       select person;
                foreach (var person in res2)
                Console.WriteLine("hent navn og køn og sorter på køn " + person.Gender + " " + person.Name);

            // Filtre og udskriv således, at der kun vises personer hvor height < 170
            var res3 = from person
                       in people
                       where person.Height < 170
                       select person;
                foreach (var person in res3)
                Console.WriteLine("hent personer mindre end 170; " + "Højde: " + person.Height + " Navn: " + person.Name);

            // Filtre og udskriv således, at der kun vises personer hvor height < 170, isHealthy = true
            var res4 = from person
                       in people
                       where person.Height < 170
                       where person.IsHealthy = true
                       select person;
                foreach (var person in res4)
                Console.WriteLine("Personer mindre end 170 og er sunde; " + "Højde: " + person.Height + " Navn: " + person.Name + " Er rask? : " + person.IsHealthy);





            Console.ReadKey();

        }
    }
}
