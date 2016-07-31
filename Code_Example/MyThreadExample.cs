using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Code_Example
{
    class MyThreadExample
    {
        private static int count1 = 0;
        private static int count2 = 0;
        Thread t1;
        Thread t2;
        public MyThreadExample() {
            t1 = new Thread(new ThreadStart(increment));
            t2 = new Thread(new ThreadStart(checkequal));
        }
        public static void Main() {
            MyThreadExample mt = new MyThreadExample();
            if (count1 == count2) { Console.WriteLine("Thread start"); }
            mt.t1.Start();
            mt.t2.Start();
            //Console.ReadLine();
        }
        void increment()
        {
            lock (this)
            {
                while (true)
                {
                    count1++; count2++;
                    //Thread.Sleep(0);
                }
            }
        }
        void checkequal()
        {
            lock (this)
            {
                while (true)
                {
                    if (count1 == count2)
                        Console.WriteLine("Synchronize");
                    else
                        Console.WriteLine("unSynchronize");
                   // Thread.Sleep(0);
                }
            }
        }
    }
}
