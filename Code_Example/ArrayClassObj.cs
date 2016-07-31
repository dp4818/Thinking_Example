using System;
using System.Collections.Generic;

using System.Text;

namespace Code_Example
{

    class IntHolder
    {
        public int i;
        internal IntHolder()
        {

        }
        internal IntHolder(int i)
        {
            this.i = i;
        }
        public override string ToString()
        {
            return i.ToString();
        }
    }
    interface A { }
    class B { }
    class ArrayClassObj 
    {
        static Random rand = new Random();
        static readonly string s = "AAA";
        
        /*
        public static void Main()
        {
            IntHolder[] a = new IntHolder[rand.Next(20) + 1];

            System.Console.WriteLine(
            "length of a = " + a.Length);
            int[] b = new int[20];
            int[][] x = new int[5][] { new int[2] {0,1 }, new int[2] { 2, 3 }, new int[2] { 4, 5 }, new int[2] { 6, 7 }, new int[2] { 8, 9 } };

            for (int i = 0; i < a.Length; i++)
            {
                
                a[i] = new IntHolder(rand.Next(500));
                System.Console.WriteLine(
                "a[" + i + "] = " + a[i]+", b["+i+"]= "+b[i]);
            }
            System.Console.WriteLine("{0}",x.Length);
            IntHolder[] c = a;
            IntHolder[] a1 = new IntHolder[rand.Next(20) + 1];
            //a[0] = a1[1];
            //a = new IntHolder[1];
            a = a1;
            if (c == a)
            {
                Console.WriteLine("c=a");
            }
            else { Console.WriteLine("c!=a"); }
            IntHolder d = new IntHolder();
            IntHolder e = d;
            //IntHolder d1 = new IntHolder();
            d.i = 1;
            //d = new IntHolder();
            //d = d1;
            if (e == d)
            {
                Console.WriteLine("e=d,d.i:{0},e.i:{1}",d.i,e.i);
            }
            else { Console.WriteLine("e!=d"); }

            string z = "ABC";
            string y = z;
            z = "DEF";
            if (y == z)
            {
                Console.WriteLine("y=z");
                Console.WriteLine("Z:{0},Y:{1}",z,y);
            }
            else { Console.WriteLine("y!=z"); Console.WriteLine("Z:{0},Y:{1}", z, y); }

            Console.ReadLine();
        }*/
    }
}
