using System;
using System.Timers;
using System.Diagnostics;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int foo;
            int var1;
            int maximum;
            int numbertotest;
            maximum = 100000;

            for (numbertotest = 2; numbertotest <= maximum; numbertotest++)
            {
                //Test Code Below
                for (foo = numbertotest / 2; foo >= 2; foo--)
                {
                    var1 = numbertotest % foo;

                    if (var1 == 0)
                    {
//                        Console.WriteLine("{0} Is Not Prime", numbertotest);
                        break;
                    }

                    if(foo == 2)
                    {
//                        Console.WriteLine("{0} Is Prime", numbertotest);
                    }
                }
            }
            Console.WriteLine("Done");
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
            Console.ReadKey();
        }
    }
}
