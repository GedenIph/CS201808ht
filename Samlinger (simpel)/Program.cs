using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samlinger__simpel_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sørg for at skabe en instans af en generisk liste som kan arbejde med en Person.
            System.Collections.Generic.List<Person> lst = new List<Person>();
            Console.WriteLine("Sørg for at skabe en instans af en generisk liste");
            Console.WriteLine("som kan arbejde med en Person.");
            Console.WriteLine(" Tilføj 3 forskellige personer ");
            Console.WriteLine("Skriv dem ud i en ForEach"); 

            //Tilføj 3 forskellige personer
            lst.Add(new Person() { Id = 1, Navn = "Peder" });
            lst.Add(new Person() { Id = 2, Navn = "Johannes" });
            lst.Add(new Person() { Id = 3, Navn = "Paula" });

            //Skriv dem ud i en ForEach
            foreach (var item in lst)


            {
                Console.WriteLine(item.Navn);
                Console.ReadKey();
            }
                
            
            //Prøv også at skabe en generisk Dictionary hvor nøglen er en int 
            //og værdien af en instans af en Person.
            Dictionary<int, Person> lst2 = new Dictionary<int, Person>();

            //Tilføj 3 forskellige personer 
            lst2.Add(1, new Person() { Id = 1, Navn = "Gurli" });
            lst2.Add(2, new Person() { Id = 2, Navn = "Jesper" });
            lst2.Add(3, new Person() { Id = 3, Navn = "Egon" });

            //og find en person udfra nøglen (lst[x]).
            var p = lst2[2];

            Console.WriteLine(p.Navn);
            Console.ReadKey();


        }
        //Du skal skabe en tom konsol app med følgende klasse:
        class Person
     {
            private int _id;

            public int Id
            {
                get { return _id; }
                set { _id = value; }
            }

            private string _navn;

            public string Navn
            {
                get { return _navn; }
                set { _navn = value; }
            }

       
            
     }



    }
}
