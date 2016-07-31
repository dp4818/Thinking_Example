using System;
using System.Collections.Generic;

using System.Text;

namespace Code_Example
{
    class Cup
    {
        internal Cup(int marker)
        {
            System.Console.WriteLine("Cup(" + marker + ")");
        }
        internal void F(int marker)
        {
            System.Console.WriteLine("f(" + marker + ")");
        }
    }
    class Cups
    {
        internal static Cup c1;
        static Cup c2;
        static Cups()
        {
            System.Console.WriteLine("Inside static Cups() constructor");
            c1 = new Cup(1);
            c2 = new Cup(2);
        }
        public Cups()
        {
            System.Console.WriteLine("Cups()");
        }
    }
    public class ExplicitStatic
    {/*
        public static void Main()
        {
            System.Console.WriteLine("Inside Main()");
            Cups.c1.F(99); // (1) print cup(1) cup(2)
            Cups x = new Cups(); //static初始化只會有一次 所以這次是print Cups()
            Console.ReadLine();
            
        }
        //static Cups x = new Cups(); // (2) 
        //static Cups y = new Cups(); // (2) */
    }
    class StaticConstructor
    {
    }
}
