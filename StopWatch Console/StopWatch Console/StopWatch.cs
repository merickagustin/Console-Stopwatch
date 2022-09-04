using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch_Console
{
    public class StopWatch
    {
        private bool IsRunning = false;
        private Stopwatch watch = new Stopwatch();
        public void Start()
        {
            if (IsRunning)
            {
                throw new InvalidOperationException("Stopwatch is already running!");
            }
            else
            {
                watch.Start();//Set to start the stopwatch
                IsRunning = true;
                Console.WriteLine("Stopwatch is now running....");
                Console.WriteLine("\n");
                Console.WriteLine("Press Spacebar key to stop");
            }
        }

        public void Stop()
        {
            if (IsRunning)
            {
                watch.Stop();//Top stop the stopwatch

                IsRunning = false;

                Console.WriteLine("Duration: {0}", watch.Elapsed);//Display the duration
                Console.WriteLine("\n");
                Console.WriteLine("Press Enter key to start");
            }
            else
                throw new InvalidOperationException("Stopwatch is not running!");

        }

    }
}
