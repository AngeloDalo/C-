using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodi
{
    class Program
    {
        static void Main(string[] args)
        {
            int primoArgomento = 10;
            int secondoArgomento = 30;
            int somma = SecondoMetodo(primoArgomento, secondoArgomento);
            Console.WriteLine(somma);
        }

        static int SecondoMetodo (int primoArgomento, int secondoArgomento)
        {
            //potevo chiamare anche int x, int y
            int totale = primoArgomento + secondoArgomento;
            return totale;
        }
    }
}
