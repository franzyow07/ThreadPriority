using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPriority
{
    internal class MyThreadClass
    {

        public static void Thread1()
        {
            Thread thread = Thread.CurrentThread;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + i);
                Thread.Sleep(500);
            }
        }

        public static void Thread2()
        {
            Thread thread = Thread.CurrentThread;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + i);
                Thread.Sleep(1500);
            }
        }
    }
}

