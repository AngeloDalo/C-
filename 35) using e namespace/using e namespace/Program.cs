using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecondoNamespace;

namespace PrimoNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            //non da errore se in Class1 non metto il namespace ma solo la classe
            //SecondaClasse sc = new SecondaClasse();
            //senza using
            //SecondoNamespace.SecondaClasse sc = new SecondoNamespace.SecondaClasse();
            SecondaClasse sc = new SecondaClasse();
            string variabileMain = sc.variabileSC;
            Console.WriteLine(variabileMain);
        }
    }
}
