﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatori_logici
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * ==
             * !=
             * <
             * <=
             * >
             * >=
             * &&
             * ||
             * !
             */
            int x = 5;
            int y = 10;
            int z = 20;
            Console.WriteLine("Scrivi stringa di testo: ");
            string testo = Console.ReadLine();
            
            if (x == 5)
            {
                Console.WriteLine("Affermazione x = 5 è vera");
            } else
            {
                Console.WriteLine("Affermazione x = 5 è falsa");
            }

            if (testo == "Hello World" || testo == "Hello world" || testo == "hello world")
            {
                Console.WriteLine("Affermazione è giusta");
            } else
            {
                Console.WriteLine("Affermazione è falsa");
            }
        }
    }
}
