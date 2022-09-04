using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopWatch_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = new ConsoleKeyInfo();
            var stopWatch = new StopWatch();

            Console.WriteLine("Press Enter key to start");
            key = Console.ReadKey();

            /*
             * While loop:
             * Enter key to begin timer
             * Spacebar key to stop the timer and display the duration
             * Escape key to quit the application
             */
            while (key.Key != ConsoleKey.Escape) {

                Console.Clear();

                if (key.Key == ConsoleKey.Enter)
                {
                    stopWatch.Start();
                }
                else if (key.Key == ConsoleKey.Spacebar)
                {
                    stopWatch.Stop();
                }

                key = Console.ReadKey();
            }
            
        }
        
    }
}
