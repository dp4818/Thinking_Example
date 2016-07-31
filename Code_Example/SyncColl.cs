using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;
namespace Code_Example
{
    class SyncCol1
    {
        public static void Main()
        {
            int iThreads = 25;
            SyncCol1 sc1 = new SyncCol1(iThreads);
            Console.WriteLine("");
        }
        int iThreads;
        SortedList myList;
        public SyncCol1(int iThreads)
        {
            this.iThreads = iThreads;
            myList = new SortedList();

            TimedWrite(myList);
            myList = SortedList.Synchronized(new SortedList());
            TimedWrite(myList);
        }

        public void TimedWrite(SortedList myList)
        {
            WriterThread.ExceptionCount = 0;
            WriterThread[] writerThreads = new WriterThread[iThreads];

            DateTime start = DateTime.Now;

            for (int i = 0; i < iThreads; i++)
            {
                writerThreads[i] = new WriterThread(myList,i);
                writerThreads[i].Start();
            }

            WaitForAllThreads(writerThreads);
            DateTime stop = DateTime.Now;
            TimeSpan elapsed = stop - start;

            System.Console.WriteLine("Synchronized List: " + myList.IsSynchronized);
            System.Console.WriteLine(iThreads + " * 5000 = " + myList.Count + "? " + (myList.Count == (iThreads *5000)));
            System.Console.WriteLine("Number of exceptions thrown: " + WriterThread.ExceptionCount);
            System.Console.WriteLine("Time of calculation = "+ elapsed);
        }
        public void WaitForAllThreads(WriterThread[] ts)
        {
            for (int i = 0; i < ts.Length; i++)
            {
                while (ts[i].Finished == false)
                {
                    Thread.Sleep(1000);
                }
            }
        }
    }
    class WriterThread
    {
        static int iExceptionsThrown = 0;
        public static int ExceptionCount
        {
            get { return iExceptionsThrown; }
            set { iExceptionsThrown = value; }
        }
        Thread t;
        SortedList theList;
        public WriterThread(SortedList theList, int i)
        {
            t = new Thread(new ThreadStart(WriteThread));
            t.IsBackground = true;
            t.Name = "Writer[" + i.ToString() + "]";
            this.theList = theList;
        }
        public bool Finished
        {
            get { return isFinished; }
        }
        bool isFinished = false;
        public void WriteThread()
        {
            for (int loop = 0; loop < 5000; loop++)
            {
                String elName = t.Name + loop.ToString();
                try
                {
                    theList.Add(elName, elName);
                }
                catch (Exception)
                {
                    ++iExceptionsThrown;
                }
            }
            isFinished = true;
            t.Abort();
        }
        public void Start()
        {
            t.Start();
        }
    }
}
