using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04TaskPerf1
{
    public class MyThreadClass
    {
        public static void Thread1()
        {
            for (int loopCount = 0; loopCount < 2; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                string output = $"Name of Thread: {thread.Name} Process = {loopCount}";

                Console.WriteLine(output);
                Debug.WriteLine(output);

           
                Thread.Sleep(500);
            }
        }
        public static void Thread2()
        {
            for (int loopCount = 0; loopCount < 6; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                string output = $"Name of Thread: {thread.Name} Process = {loopCount}";

                Console.WriteLine(output);
                Debug.WriteLine(output);
           
                Thread.Sleep(1500);
            }//end of thread
        }
    }
    }