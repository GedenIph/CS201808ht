using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser_Terning
{//ikke færdig!!!!!!! - løsning er copy/paste - skal forstå!!


    //Du skal skabe en tom konsol app med en klasse Terning (i en fil for sig selv) med følgende medlemmer:

    public class Terning
    {
        private static Random rnd = new Random();
        public int værdi;
        private bool snyd;

        public Terning()
        {
            this.værdi = 1;
            this.snyd = false;
        }

        public Terning(bool snyd)
        {
            this.snyd = snyd;
            Ryst();
        }
        public void Skriv()
        {
            Console.WriteLine("[" + this.værdi + "]");
        }

        public void Ryst()
        {
            if (snyd)
                this.værdi = 6;
            else
                this.værdi = rnd.Next(1, 7);
        }
    }
}
