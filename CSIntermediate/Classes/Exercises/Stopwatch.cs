using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSIntermediate.Classes.Exercises
{
    public class Stopwatch
    {
        private string stopEnter = "";
        private DateTime startTime = new DateTime();
        private DateTime endTime = new DateTime();
        //TimeSpan timeSpan = new TimeSpan(0,0,0);
        public Stopwatch() { }

        public void Start()
        {
            var count = 1;
            do
            {
                Console.WriteLine("Timer started..");
                this.startTime = DateTime.Now;
                Console.WriteLine("for stop, press Enter! Or for new round press any letter or number");
                stopEnter = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(stopEnter))
                {
                    Console.WriteLine("{0}.Round : {1}",count, Stop());
                    count++;
                    continue;
                }
                 
                
                if (String.IsNullOrWhiteSpace(stopEnter))
                {
                    Console.WriteLine(Stop());
                    break;
                }
            }while (true);

        }

        public TimeSpan Stop()
        {
            this.endTime = DateTime.Now;
            return endTime - startTime;
        }

        
    }

}

