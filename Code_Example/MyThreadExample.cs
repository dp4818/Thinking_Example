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
        private readonly Thread t1; //readonly : 在run-time initial
        Thread t2;
        private readonly object m_SyncObj = new object(); //never lock (this) !

        public MyThreadExample() {
            t1 = new Thread(increment) { IsBackground = true }; //這樣寫就可以了
            t2 = new Thread(new ThreadStart(checkequal)) { IsBackground = true };//isbackground預設false
            //為什麼要加上isbackground? main結束了 那background thread就會自動跟著結束
            //如果不設成background thread 那main都結束了 程式卻不會結束 繼續跑thread
        }
        public static void Main() {
            MyThreadExample mt = new MyThreadExample();
            if (count1 == count2) { Console.WriteLine("Thread start"); }
            mt.t1.Start();
            mt.t2.Start();
            Console.ReadLine(); //如果不加上readline 當main執行完 程式就結束了(因為thread isbackground=true)
        }
        void increment()
        {
            while (true)
            {
                lock (m_SyncObj)
                {
                    count1++; count2++;
                }
                Thread.Sleep(1000);
            }
        }
        void checkequal()
        {
                while (true)
                {
                    lock (m_SyncObj)
                    {
                        Console.WriteLine((count1 == count2) ? "Synchronize" : "unSynchronize");
                    /*
                    if (count1 == count2)
                        Console.WriteLine("Synchronize");
                    else
                        Console.WriteLine("unSynchronize");
                    */
                    }
                    Thread.Sleep(1000); 
                }
        }
    }
}
