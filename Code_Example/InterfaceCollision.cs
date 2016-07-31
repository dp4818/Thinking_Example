using System;
using System.Collections.Generic;

using System.Text;

namespace Code_Example
{
    interface I1 { void F(); }
    interface I2 { int F(int i); }
    interface I3 { int F(); }
    class C { public virtual int F() { return 1; } }
    class C2 : I1, I2
    {
        public void F() { }
        public int F(int i) { return 1; }
    }
    class C3 : C, I2
    {
        public int F(int i) { return 1; }
    }
    class C4 : C, I3
    {
        // Identical, no problem:
        public override int F() { return 1; }
    }
    class C5 : C, I1
    {
        public override int F() { return 1; }
        void I1.F() { }
    }
    interface I4 : I1, I3 { }
    class C6 : I4
    {
        void I1.F() { }
        int I3.F() { return 1; }
    }
    class InterfaceCollision
    {
    }
    class G { interface H { } H a; }
    
}
