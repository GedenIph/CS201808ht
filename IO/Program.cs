using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    /// <summary>
    /// Du skal skabe en konsol app hvor du skal benytte System.IO.File og System.IO.Directory til at:
    /// </summary>



    class Program
    {
        static void Main(string[] args)
        {

            //Udskrive en boolsk værdi svarende til om mappen c:\temp eksisterer (hvis den ikke findes så opret den og placer et par filer i)

            Console.WriteLine($"Eksisterer c:\\temp: {System.IO.Directory.Exists(@"c:\temp")}");

            //Udskrive navnet på samtlige filer i mappen

            foreach (var item in System.IO.Directory.GetFiles(@"c:\temp"))
            Console.WriteLine(item);

            //Udskrive en boolsk værdi svarende til om mappen c:\temp\data.txt eksisterer

            Console.WriteLine($"Eksisterer c:\\temp\\data.txt: {System.IO.File.Exists(@"c:\temp\data.txt")}");


            //(Over)skrive indholdet i c:\temp\data.txt med "xxx" (brug WriteAllText)

            System.IO.File.WriteAllText(@"c:\temp\data.txt", "Jeg er en lille kamel, der godt kan lide at danse lambada (XXX)");

            //Tilføje "yyy" til filen (brug AppendAllText)

            System.IO.File.AppendAllText(@"c:\temp\data2.txt", Environment.NewLine + "Og jeg tilføjer lidt ekstra til teksten med dette script SØHEST (YYY)");

            System.IO.File.AppendAllText(@"c:\temp\data3.txt", Environment.NewLine + "OS version: " + Environment.OSVersion);

            //Hent indhold til en string variabel og skriv den ud (brug ReadAllText)

            System.IO.File.







            Console.ReadKey();






        }
    }
}
