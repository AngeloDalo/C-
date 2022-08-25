﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipi_generici
{
    class Program
    {
        static void Main(string[] args)
        {
            //utilizzate quando creiamo un programma modulare nel quale non conosciamo il determinato tipo
            //di dati con cui andremo a lavorare, diamo un segnaposto a questi dati che verrà compilato con
            //il tipo giusto, al momento del suo richiamo
            ClaaseGenerica<string, int> tutorial1 = new ClaaseGenerica<string, int>();
            tutorial1.elemento = "Hello World";
            tutorial1.elemento2 = 100;
            Console.WriteLine(tutorial1.elemento + " " + tutorial1.elemento2);
        }
    }
    public class ClaaseGenerica<T, U>
    {
        public T elemento;
        public U elemento2;
    }
}
