﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcolatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0;
            double n2 = 0;
            string operazione = "0";
            bool ripetizione = false;
            //primo numero
            Console.WriteLine("Scegli il primo numero");
            n1 = Convert.ToDouble(Console.ReadLine());
            //operazione
            do
            {
                do
                {
                    Console.WriteLine("\nScegli un operazione matematica");
                    Console.WriteLine("01 - Addizion\n02 - Sottrazione\n03 - Moltiplicazione\n04 - Divisione\n05 - Totale\n06 - Cancella");
                    operazione = Console.ReadLine();
                } while (operazione != "1" && operazione != "2" && operazione != "3" && operazione != "4" && operazione != "5" && operazione != "6");
                //secondo numero
                if (operazione != "5" && operazione != "6")
                {
                    Console.WriteLine("\nScegli un numero");
                    n2 = Convert.ToDouble(Console.ReadLine());
                }

                switch (operazione)
                {
                    case "1": n1 = n1 + n2; Console.WriteLine("\nTotale ultima operazione: " + n1); ripetizione = true; break;
                    case "2": n1 = n1 - n2; Console.WriteLine("\nTotale ultima operazione: " + n1); ripetizione = true; break;
                    case "3": n1 = n1 * n2; Console.WriteLine("\nTotale ultima operazione: " + n1); ripetizione = true; break;
                    case "4": n1 = n1 / n2; Console.WriteLine("\nTotale ultima operazione: " + n1); ripetizione = true; break;

                    case "5": Console.WriteLine("\nTOTALE: " + n1); ripetizione = false; goto case "6";
                    case "6":
                        n1 = 0;
                        n2 = 0;
                        operazione = "0";
                        ripetizione = true; 
                        Console.WriteLine("\nTUTTO E' STATO CANCELLATO");
                        Console.WriteLine("\nPer riniziare i calcoli, scrivi il primo numero: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        break;
                }
            } while (ripetizione == true);
        }
    }
}
