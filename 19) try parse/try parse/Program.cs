using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_parse
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            //x = int.Parse(Console.ReadLine());
            //se metto lettera da errore
            int.TryParse(Console.ReadLine(), out x);
            //prova a convertire in intero, se inserisco un non numero da 0 come risultato
        }
    }
}
