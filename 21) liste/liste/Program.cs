﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primaLista = new List<int>();
            primaLista.Add(100);
            primaLista.Add(200);
            primaLista.Add(300);
            primaLista.Add(400);
            primaLista.Add(500);
            primaLista.Add(600);
            //array molto dipendente dal contatore
            //nelle liste posso eliminare tranquillamente elementi senza problemi
            Console.WriteLine(primaLista[1]);
            primaLista.Remove(200);
            Console.WriteLine(primaLista[1]);
            Console.WriteLine("valori totali: " + primaLista.Count);
        }
    }
}
