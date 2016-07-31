using System;
using System.Collections.Generic;

using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Code_Example
{
    class Sharing1 :Form
    {
        private TextBox accessCountBox = new TextBox();
        private Button start = new Button();
        private Button watch = new Button();
        private int accessCount = 0;
        public void incrementAccess()
        {
            accessCount++;
            accessCountBox.Text = accessCount.ToString();
        }
        private int numCounters = 12;
        private int numWatchers = 15;
        private TwoCounter[] s;
        public Sharing1()
        {
            ClientSize = new Size(450, 480);
            Panel p = new Panel();
            p.Size = new Size(400, 50);

            start.Click += new EventHandler(StartAllThreads);
            watch.Click += new EventHandler(StartAllWatchers);

            accessCountBox.Text = "0";
            accessCountBox.Location = new Point(10, 10);
            start.Text = "Start threads";
            start.Location = new Point(110, 10);
            watch.Text = "Begin watching";
            watch.Location = new Point(210, 10);

            p.Controls.Add(start);
            p.Controls.Add(watch);
            p.Controls.Add(accessCountBox);

            s = new TwoCounter[numCounters];
            for (int i = 0; i < s.Length; i++) //加入TwoConuter Panel
            {
                s[i] = new TwoCounter(new TwoCounter.IncrementAccess(incrementAccess));
                //利用委派由twocounter決定何時使用方法
                s[i].Location = new Point(10, 50 + s[i].Height * i);
                Controls.Add(s[i]);
            }
            this.Closed += new EventHandler(StopAllThreads);
            Controls.Add(p);
        }
        public void StartAllThreads(Object sender, EventArgs
        args)
        {
            for (int i = 0; i < s.Length; i++)
                s[i].Start(); //所有的thread會一起開始
        }
        public void StopAllThreads(Object sender, EventArgs
        args)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != null)
                {
                    s[i].Stop();
                }
            }
        }
        public void StartAllWatchers(Object sender, EventArgs
        args)
        {
            for (int i = 0; i < numWatchers; i++)
                new Watcher(s);
        }/*
        public static void Main(string[] args)
        {
            Sharing1 app = new Sharing1();
            if (args.Length > 0)
            {
                app.numCounters = SByte.Parse(args[0]);
                if (args.Length == 2)
                {
                    app.numWatchers = SByte.Parse(args[1]);
                }
            }
            Application.Run(app);
        }*/
    }
    class TwoCounter : Panel
    {
        private bool started = false;
        private Label t1;
        private Label t2;
        private Label lbl;
        private Thread t;
        private int count1 = 0, count2 = 0;
        
        public delegate void IncrementAccess();
        IncrementAccess del;
        
        // Add the display components
        public TwoCounter(IncrementAccess del)
        {
            this.del = del;
            this.Size = new Size(350, 30);
            this.BorderStyle = BorderStyle.Fixed3D;

            t1 = new Label();
            t1.Location = new Point(10, 10);
            t2 = new Label();
            t2.Location = new Point(110, 10);
            Label.CheckForIllegalCrossThreadCalls = false;

            lbl = new Label();
            lbl.Text = "Count1 == Count2";
            lbl.Location = new Point(210, 10);
            Controls.AddRange(new Control[]{t1, t2,
lbl});
            //Initialize the Thread
            t = new Thread(new ThreadStart(run));
        }
        public void Start()
        {
            if (!started)
            {
                started = true; //防止thread被重複呼叫(start)
                t.Start();
            }
        }
        public void Stop()
        {
            t.Abort();
        }
        public void run()
        {
            while (true)
            {
                
                t1.Text = (++count1).ToString();
                t2.Text = (++count2).ToString();
                Thread.Sleep(500);
            }
        }
        public void synchTest() //由watcher呼叫
        {
            del();
            if (count1 != count2)
                lbl.Text = "Unsynched";
        }
    }
    class Watcher
    {
        TwoCounter[] s;
        public Watcher(TwoCounter[] s)
        {
            this.s = s;
            new Thread(new ThreadStart(run)).Start();
        }
        public void run()
        {
            while (true)
            {
                for (int i = 0; i < s.Length; i++)
                    s[i].synchTest(); //每個twocounter都會呼叫synchTest 不斷累績在private accessCount上
                Thread.Sleep(500);
            }
        }
    }
    }
