﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coversioni
{
    class Program
    {
        static void Main(string[] args)
        {
            //convertire tipi variabile
            string testo = "Hello world";
            int numeroIntero = 22;
            testo = numeroIntero.ToString();
            Console.WriteLine("variabile numeroIntero = " + numeroIntero);
            Console.WriteLine("variabile testo = " + testo);

            numeroIntero += 10;
            testo += 10;
            Console.WriteLine("variabile numeroIntero = " + numeroIntero); //stampa 32
            Console.WriteLine("variabile testo = " + testo); //stampa 2210

            float numeroVirgola = 2.7f;
            numeroVirgola = numeroIntero; //mettere numero intero in float senza problemi
            Console.WriteLine("variabile numeroVirgola = " + numeroVirgola); 
            //per mettere un float in int devo convertirlo
            float numeroVirgola2 = 2.7f;
            numeroIntero = Convert.ToInt32(numeroVirgola2); //primo metodo
            Console.WriteLine("variabile numeroIntero = " + numeroIntero);
            //trasformazione avviene per arrotondamento verso il pari nel caso del .5
            //nel caso voglio solamente il valore prima della virgola
            float numeroaVirgola3 = 5.9f;
            int numeroIntero2 = 1;
            numeroIntero2 = (int)numeroaVirgola3; //non specifico il numero dei bit, secondo metodo
            Console.WriteLine("variabile numeroIntero2 = " + numeroIntero2);
        }
    }
}
