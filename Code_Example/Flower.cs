using System;
using System.Collections.Generic;

using System.Text;

namespace Code_Example
{
    class Flower
    {
        int petalCount = 0;
        string s = "null";
        Flower(int petals) //順序二
        {
            petalCount = petals; //petal被換成47了
            System.Console.WriteLine(
            "Constructor w/ int arg only, petalCount= "
            + petalCount);
        }
        Flower(string ss)
        {
            System.Console.WriteLine(
            "Constructor w/ string arg only, s=" + ss);
            s = ss;
        }
        Flower(string s, int petals) : this(petals) //順序一
        {
            //! this(s); // Can't call two!
            this.s = s; // Another use of "this" //順序三 s 被換成hi了
            System.Console.WriteLine("string & int args");
        }
        Flower() : this("hi", 47)
        {
            System.Console.WriteLine(
            "default constructor (no args)");
        }
        void Print()
        {
            System.Console.WriteLine(
            "petalCount = " + petalCount + " s = " + s);
        }/*
        public static void Main()
        {
            Flower x = new Flower();
            x.Print(); //順序四
            Console.ReadLine();
        }*/
    }
}
