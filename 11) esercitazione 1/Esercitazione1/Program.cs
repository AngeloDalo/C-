using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto, come vuoi farti chiamare?");
            string name = Console.ReadLine();
            Console.WriteLine($"Salve {name}, sei pronto per il quiz?\nPremi un tasto per iniziare");
            Console.ReadLine();
            string risposta1, risposta2, risposta3;
            bool errata1 = false;
            bool errata2 = false;
            bool errata3 = false;
            int esatte = 0;
            int sbagliate = 0;

            //DOMANDA 1
            Console.WriteLine("\n");
            Console.WriteLine("Qunato fa 2+2?");
            risposta1 = Console.ReadLine();
            if(risposta1 == "4")
            {
                esatte++;
            } else
            {
                sbagliate++;
                errata1 = true;
            }

            //DOMANDA 2
            Console.WriteLine("\n");
            Console.WriteLine("Come si scrive a lettere il numero della risposta precedente?");
            risposta2 = Console.ReadLine();
            if (risposta2 == "quattro" || risposta2 == "Quattro" || risposta2 == "QUATTRO")
            {
                esatte++;
            }
            else
            {
                sbagliate++;
                errata2 = true;
            }

            //DOMANDA 3
            Console.WriteLine("\n");
            Console.WriteLine("Quante lettere ci sono nella parola della risposta precedente");
            risposta3 = Console.ReadLine();
            if (risposta3 == "7" || risposta3== "sette" || risposta3 == "Sette" || risposta3 == "SETTE")
            {
                esatte++;
            }
            else
            {
                sbagliate++;
                errata3 = true;
            }

            //CORREZZIONE
            Console.WriteLine("Quiz finito!!\n");
            Console.WriteLine($"Risposte esatte {esatte}");
            Console.WriteLine($"Risposte sbagliate {sbagliate}");
            if(errata1 == true)
            {
                Console.WriteLine($"Alla prima domanda, hai risposto {risposta1} invece di '4");
            }
            if (errata2 == true)
            {
                Console.WriteLine($"Alla prima domanda, hai risposto {risposta2} invece di 'quattro");
            }
            if (errata3 == true)
            {
                Console.WriteLine($"Alla prima domanda, hai risposto {risposta3} invece di '7");
            }
        }
    }
}
