﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reference_out_e_overload_dei_metodi
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine(x);
            SecondoMetodo(ref x);
            TerzoMetodo(out int y);
            Console.WriteLine(x); //x=20
            Console.WriteLine(y); //y=40
            int xx = 10;
            int yy = 20;
            float zz = 5.5f;
            int somma1 = MarioRossi(xx, yy);
            float somma2 = MarioRossi(xx, yy, zz);
            Console.WriteLine(somma1);
            Console.WriteLine(somma2);
        }
        static void SecondoMetodo(ref int x)
        {
            x = 20;
        }
        static void TerzoMetodo(out int y)
        {
            y = 40;
        }
        static int MarioRossi (int x, int y)
        {
            int totale = x + y;
            return totale;
        }
        static float MarioRossi (int x, int y, float z)
        {
            float totale = x + y + z;
            return totale;
        }
    }
}
