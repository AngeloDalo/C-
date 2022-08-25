using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumerazione
{
    class Program
    {
        static void Main(string[] args)
        {
            arcobaleno primaEnum = arcobaleno.rosso;
            Console.WriteLine("dichiaro una prima enum = " + primaEnum); //rosso
            string varString = arcobaleno.arancione.ToString();
            Console.WriteLine("converto in string = " + varString); //arancione
            int varInt = (int)arcobaleno.giallo;
            Console.WriteLine("converto in int = " + varInt); //2
            int varInt2 = (int)arcobaleno.verde;
            Console.WriteLine("imposto un valore di 30 al verde = " + varInt2); //30
            int varInt3 = (int)arcobaleno.blu;
            Console.WriteLine("imposto un valore di blu = " + varInt3); //31
        }
    }
    public enum arcobaleno
    {
        //usate quando a variabile si deve obbligatoriamente dare uno dei valori prestabiliti da noi
        //all'interno di un elenco /set dichiarato: giorni settimana, mesi anno
        rosso,
        arancione,
        giallo,
        verde = 30,
        blu,
        violetto
    }
}
