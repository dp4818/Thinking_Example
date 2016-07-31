using System;
using System.Collections.Generic;

using System.Text;

namespace Code_Example
{
    class PrimitiveOverloading
    {
        static void Prt(string s)
        {
            System.Console.WriteLine(s);
        }
        void F1(char x) { Prt("F1(char)"); }
        void F1(byte x) { Prt("F1(byte)"); }
        void F1(short x) { Prt("F1(short)"); }
        void F1(int x) { Prt("F1(int)"); }
        void F1(long x) { Prt("F1(long)"); }
        void F1(float x) { Prt("F1(float)"); }
        void F1(double x) { Prt("F1(double)"); }
        void F2(byte x) { Prt("F2(byte)"); }
        void F2(short x) { Prt("F2(short)"); }
        void F2(int x) { Prt("F2(int)"); Console.Write("{0}",x); }
        void F2(long x) { Prt("F2(long)"); }
        void F2(float x) { Prt("F2(float)"); }
        void F2(double x) { Prt("F2(double)"); }
        void F3(short x) { Prt("F3(short)"); }
        void F3(int x) { Prt("F3(int)"); }
        void F3(long x) { Prt("F3(long)"); }
        void F3(float x) { Prt("F3(float)"); }
        void F3(double x) { Prt("F3(double)"); }
        void F4(int x) { Prt("F4(int)"); }
        void F4(long x) { Prt("F4(long)"); }
        void F4(float x) { Prt("F4(float)"); }
        void F4(double x) { Prt("F4(double)"); }
        void F5(long x) { Prt("F5(long)"); }
        void F5(float x) { Prt("F5(float)"); }
        void F5(double x) { Prt("F5(double)"); }
        void F6(float x) { Prt("F6(float)"); }
        void F6(double x) { Prt("F6(double)"); }
        void F7(double x) { Prt("F7(double)"); }

        void TestConstVal()
        {
            Prt("Testing with 5");
            F1(5); F2(5); F3(5); F4(5); F5(5); F6(5); F7(5);
        }
        void TestChar()
        {
            char x = 'x';
            Prt("char argument:");
            F1(x); F2(x); F3(x); F4(x); F5(x); F6(x); F7(x); //如果沒有char constructor 則會使用int
        }
        void TestByte()
        {
            byte x = 0;
            Prt("byte argument:");
            F1(x); F2(x); F3(x); F4(x); F5(x); F6(x); F7(x);
        }
        void TestShort()
        {
            short x = 0;
            Prt("short argument:");
            F1(x); F2(x); F3(x); F4(x); F5(x); F6(x); F7(x);
        }
        void TestInt()
        {
            int x = 0;
            Prt("int argument:");
            F1(x); F2(x); F3(x); F4(x); F5(x); F6(x); F7(x);
        }
        void TestLong()
        {
            long x = 0;
            Prt("long argument:");
            F1(x); F2(x); F3(x); F4(x); F5(x); F6(x); F7(x);
        }
        void TestFloat()
        {
            float x = 0;
            Prt("Float argument:");
            F1(x); F2(x); F3(x); F4(x); F5(x); F6(x); F7(x);
        }
        void TestDouble()
        {
            double x = 0;
            Prt("double argument:");
            F1(x); F2(x); F3(x); F4(x); F5(x); F6(x); F7(x);
        }/*
        public static void Main()
        {
            
            PrimitiveOverloading p = new PrimitiveOverloading();
            p.TestConstVal();
            p.TestChar();
            p.TestByte();
            p.TestShort();
            p.TestInt();
            p.TestLong();
            p.TestFloat();
            p.TestDouble();
            Console.ReadLine();
            
        }*/
    }
}
