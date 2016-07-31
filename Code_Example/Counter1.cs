using System;
using System.Collections.Generic;

using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;


namespace Code_Example
{
    class Counter1 : Form
    {
        int numberToCountTo;
        Counter1(int numberToCountTo)
        {
            this.numberToCountTo = numberToCountTo;
            ClientSize = new System.Drawing.Size(500, 300);
            Text = "Responsive interface";
            Button start = new Button();
            start.Text = "Start";
            start.Location = new Point(10, 10);

            start.Click += new EventHandler(StartCounting);

            Button onOff = new Button();
            onOff.Text = "Toggle";
            onOff.Location = new Point(10, 40);

            onOff.Click += new EventHandler(StopCounting);
       
            Controls.AddRange(new Control[] { start, onOff });
        }
        public void StartCounting(Object sender, EventArgs args)
        {
            ThreadStart del = new ThreadStart(paintScreen);
            Thread t = new Thread(del);
            t.Start();
        }
        public void paintScreen() {
            Form.CheckForIllegalCrossThreadCalls = false;
            Control.CheckForIllegalCrossThreadCalls = false;
            Rectangle bounds = Screen.GetBounds(this);
            int width = bounds.Width;
            int height = bounds.Height;
            Graphics g = Graphics.FromHwnd(this.Handle);
            Pen pen = new Pen(Color.Red, 1);
            Random rand = new Random();
            runFlag = true;
            for (int i = 0; runFlag && i < numberToCountTo;
            i++)
            {
                //Do something mildly time-consuming
                int x = rand.Next(width);
                int y = rand.Next(height);
                g.DrawRectangle(pen, x, y, 1, 1);
                Thread.Sleep(10);
            }
        }
        bool runFlag = true;
        public void StopCounting(Object sender, EventArgs
        args)
        {
            runFlag = false;
        }/*
        public static void Main()
        {
            Application.Run(new Counter1(10000));
        }*/
    }
}
