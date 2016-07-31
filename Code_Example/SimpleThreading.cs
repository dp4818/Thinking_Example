using System;
using System.Collections.Generic;

using System.Text;
using System.Threading;
namespace Code_Example
{
    class SimpleThreading
    {
        private int countDown = 5;
        private static int threadCount = 0;
        private int threadNumber = ++threadCount;
        public SimpleThreading()
        {
            System.Console.WriteLine("Making " + threadNumber);
        }
        public void run()
        {
            while (true)
            {
                System.Console.WriteLine("Thread " + threadNumber + "(" + countDown + ")");
                if (--countDown == 0) return;
            }
        }/*
        public static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                SimpleThreading st = new SimpleThreading();
                Thread aThread = new Thread(new
                ThreadStart(st.run));
                aThread.Start();
            }
            System.Console.WriteLine("All Threads Started");
            Console.ReadLine();
        }*/
    }
}
