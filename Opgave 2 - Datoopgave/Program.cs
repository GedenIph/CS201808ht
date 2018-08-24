using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_2___Datoopgave
{
    class Program
    {
        static void Main(string[] args)
        {

            System.DateTime d1;
            //Assign d1 til today date and time
            d1 = DateTime.Now;

            // Add 10 days to d1
            d1 = d1.AddDays(10);
            Console.WriteLine(d1);

            // Add 20 minutes to datetime            
            d1 = d1.AddMinutes(20);
            Console.WriteLine(d1);

            //substract 1 months from datetime
            d1 = d1.AddMonths(-1);
            Console.WriteLine(d1);

            //Prøv at oprette to DatimeTime variabler (d2 ogg d3) og træk dem fra hinanden og udskriv antal dage

            System.DateTime d2 = new DateTime(2018, 1, 1);
            System.DateTime d3 = new DateTime(2018, 5, 1);
            
            Console.WriteLine("d2=");
            Console.WriteLine(d2);

            Console.WriteLine("d3=");
            Console.WriteLine(d3);

            TimeSpan tidsForskel;
            tidsForskel = d3.Subtract(d2);
            Console.WriteLine("Tidsforskel mellem d3 og d2");
            Console.WriteLine(tidsForskel.Days);

            // ER IKKE FÆRDIG!!!!!
            TimeSpan t2 = new TimeSpan(16, 0, 0);
            Console.WriteLine(t2);
            TimeSpan t3 = new TimeSpan






            Console.ReadKey();



        }
    }
}
