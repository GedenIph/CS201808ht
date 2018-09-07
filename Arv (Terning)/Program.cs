using System;
using static Arv__Terning_.Terning;

namespace Arv__Terning_
{
    class Program
    {
        static void Main(string[] args)
        {

            Terning t = new Terning();
            t.Skriv();
            t.Ryst();
            t.Skriv();


            LudoTerning l = new LudoTerning();
            l.Skriv();
            Console.WriteLine(l.ErGlobus());
            Console.WriteLine(l.ErStjerne());

            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    // Du skal skabe en tom konsol app med en klasse Terning med følgende medlemmer:
    public class Terning
    {
        //En privat statisk instans af System.Random (initialiseres i en statisk constructor)
        private static System.Random rnd;

        //(initialiseres i en statisk constructor)
        static Terning()
        {
            rnd = new Random();
        }

        //En offentlig egenskab (int) Værdi (med private felt kaldet værdi). 
        //Der må ikke tildeles et tal mindre end en eller større end seks. 
        //Hvis det sker sættes værdi blot til en.
        private int værdi;

        public int Værdi
        {
            get
            {
                //Console.WriteLine("Terning aflæses som " + this.værdi);
                return this.værdi;
            }
            set
            {
                if (value < 0 || value > 6)
                    value = 1;
                //Console.WriteLine("Terning tildeles " + value);
                this.værdi = value;
            }
        }


        //En Offentlig metode Skriv() der viser terningen (eksempelvis [1] eller [2])
        public virtual void Skriv()
        {
            Console.WriteLine("[" + this.Værdi + "]");
        }

        //En offentlig metode Ryst() der giver et tilfældigt tal
        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }


        //Tilføj en default constructor (hvor Ryst kaldes)
        public Terning()
        {
            this.Ryst();
        }

        //og en custom constructor hvor værdi kan angives når der oprettes en instans.
        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }




        //Skab nu en ny klasse LudoTerning der arver fra Terning. Klassen har to metoder

        public class LudoTerning : Terning
        {

            // ErGlobus() returnerer true hvis værdien er 3 – ellers false
            public bool ErGlobus()
            {
                return this.Værdi == 3;
            }

            // ErStjerne() returnerer true hvis værdien er 5 – ellers false
            public bool ErStjerne()
            {
                return this.Værdi == 5;
            }

            //Sørg for at der både er en default 
            //og custom constructor der kalder ”mor” uden yderligere funktionalitet
            public LudoTerning() : base()
            { }

            public LudoTerning(int værdi) : base(værdi)
            { }

            //Sørg for at Skriv kan overskrives 
            //så den returnerer eksempelvis [1] [2] [G] [4] [S] [6]

            public override void Skriv()
            {
                switch (this.Værdi)
                {
                    case 3:
                        Console.WriteLine("[G]");
                        break;
                    case 5:
                        Console.WriteLine("[S]");
                        break;
                    default:
                        base.Skriv();
                        break;
                }
            }


        }

    }
}