using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scope
{
    class Program
    {
        static int x = 50; //posso usarla in tutti i static void
        static void Main(string[] args)
        {
            //SCOPE=dove vive la variabile
            //int x = 50;
            int y = 20;

            if(y==20)
            {
                x = 500;
                int z = 30;
                Console.WriteLine(x);
                Console.WriteLine(z);
            }
            //z vive solo dentro la funzione
            //Console.WriteLine(z);
            Console.WriteLine(x);
            
            MarioRossi();
        }

        static void MarioRossi()
        {
            //non esiste x
            Console.WriteLine(x);
        }
    }
}
