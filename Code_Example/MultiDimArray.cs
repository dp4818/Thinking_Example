using System;
using System.Collections.Generic;

using System.Text;

namespace Code_Example
{
    class MultiDimArray
    {
        static Random rand = new Random();
        static void Prt(string s)
        {
            System.Console.WriteLine(s);
        }
        /*
        public static void Main()
        {
            int[,] a1 = { { 1, 2, 3, }, { 4, 5, 6, }, };
            Prt("a1.Length = " + a1.Length);
            Prt(" == " + a1.GetLength(0) + " * " +
            a1.GetLength(1));
            for (int i = 0; i < a1.GetLength(0); i++)
                for (int j = 0; j < a1.GetLength(1); j++)
                    Prt("a1[" + i + "," + j +
                    "] = " + a1[i, j]);

            // 3-D rectangular array:
            int[,,] a2 = new int[2, 2, 4];
            
            for (int i = 0; i < a2.GetLength(0); i++)
                for (int j = 0; j < a2.GetLength(1); j++)
                    for (int k = 0; k < a2.GetLength(2);
                    k++)
                        Prt("a2[" + i + "," +
                        j + "," + k +
                        "] = " + a2[i, j, k]);
            Prt("" + a2.Length);
            // Jagged array with varied-Length vectors:
            int[][][] a3 = new int[rand.Next(7) + 1][][];
            for (int i = 0; i < a3.Length; i++)
            {
                a3[i] = new int[rand.Next(5) + 1][];
                for (int j = 0; j < a3[i].Length; j++)
                    a3[i][j] = new int[rand.Next(5) + 1];
            }
            
            for (int i = 0; i < a3.Length; i++)
                for (int j = 0; j < a3[i].Length; j++)
                    for (int k = 0; k < a3[i][j].Length;
                    k++)
                        Prt("a3[" + i + "][" +
                        j + "][" + k +
                        "] = " + a3[i][j][k]);
            Prt("" + a3.Length);
            // Array of nonprimitive objects:
            IntHolder[,] a4 = {
                { new IntHolder(1), new IntHolder(2)},
                { new IntHolder(3), new IntHolder(4)},
                { new IntHolder(5), new IntHolder(6)},
            };
            
            for (int i = 0; i < a4.GetLength(0); i++)
                for (int j = 0; j < a4.GetLength(1); j++)
                    Prt("a4[" + i + "," + j +
                    "] = " + a4[i, j]);
            Prt("" + a4.Length);
            IntHolder[][] a5;
            a5 = new IntHolder[3][];
            for (int i = 0; i < a5.Length; i++)
            {
                a5[i] = new IntHolder[3];
                for (int j = 0; j < a5[i].Length; j++)
                {
                    a5[i][j] = new IntHolder(i * j);
                }
            }
            
            for (int i = 0; i < a5.GetLength(0); i++)
            {
                for (int j = 0; j < a5[i].Length; j++)
                {
                    Prt("a5[" + i + "][" + j +
                    "] = " + a5[i][j]);
                }
            }
            Prt("" + a5.Length);
            Console.ReadLine();
        }*/
    }
}
