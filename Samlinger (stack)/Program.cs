using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samlinger__stack_
{
    class Program
    {
        static void Main(string[] args)
        {
            Bunke b = new Bunke();
            b.TilføjKort(new Kort() { Kulør = "Spar", Værdi = 2 });
            b.TilføjKort(new Kort() { Kulør = "Hjerter", Værdi = 14 });
            b.TilføjKort(new Kort() { Kulør = "Ruder", Værdi = 3 });
            b.Vis();

            var k = b.FjernKort();
            Console.WriteLine();
            Console.WriteLine(k);
            Console.WriteLine();

            b.Vis();

            Console.ReadKey();
        }


    }

    /// Du skal skabe en tom konsol app med følgende klasse:

    /// public class Kort
    //public string Kulør { get; set; }
    //public int Værdi { get; set; }
    //public override string ToString()
    //{
    //  return this.Kulør + " " + this.Værdi;
    //}


    class Kort
    {
        private string _kulør;

        public string Kulør
        {
            get { return _kulør; }
            set { _kulør = value; }
        }

        private int _Værdi;

        public int Værdi
        {
            get { return _Værdi; }
            set { _Værdi = value; }
        }

        public override string ToString()
        {
            return this.Kulør + " " + this.Værdi;
        }
    }

    class Bunke
    {
        private Stack<Kort> bunke = new Stack<Kort>();
        public void TilføjKort(Kort k)
        {
            bunke.Push(k);
        }

        public Kort FjernKort()
        {
            if (bunke.Count > 0)
                return bunke.Pop();
            return null;
        }

        public void Vis()
        {
            foreach (var item in bunke)
            {
                Console.WriteLine(item);
            }
        }

    }
}

    




