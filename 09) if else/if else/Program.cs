﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            if (x == 5)
            {
                Console.WriteLine("x è uguale a 5");
            } else if (x == 7)
            {
                Console.WriteLine("x è uguale a 7");
            } else
            {
                Console.WriteLine("non so quanto vale x");
            }
        }
    }
}
