using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates__log_
{
    class Program
    {
        static void Main(string[] args)
        {
        
                Maskine m = new Maskine();
                m.Log = Console.WriteLine;
                m.Log += AppendLog;
                m.Start();
                m.Stop();


            Maskine2 i = new Maskine2();
            i.Log = Console.WriteLine;
            i.Log += AppendLog;
            i.Start();
            i.Stop();

            Console.ReadKey();

        }

        static void AppendLog(string txt)
        {
            System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n");
        }



    }

    public delegate void LogDelegate(string txt);

    public class Maskine
    {

        public LogDelegate Log { get; set; }

        public void Start()
        {
            Log(DateTime.Now.ToString() + " Starter");
        }
        public void Stop()
        {
            Log(DateTime.Now.ToString() + " Stopper");
        }
    }

    
    public class Maskine2
    {

        public Action<string> Log { get; set; }

        public void Start()
        {
            Log(DateTime.Now.ToLongTimeString() + " Starter");
        }
        public void Stop()
        {
            Log(DateTime.Now.ToLongTimeString() + " Stopper");
        }
    }





}
