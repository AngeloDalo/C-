using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operazioni_matematiche
{
    class Program
    {
        static void Main(string[] args)
        {
            // + - * / %(resto)
            float x = 2.2f; //se lo scrivo nel cmd devo mettere la ,
            Console.WriteLine(x);
            x = 10f / 3f;
            //con la divisione mettere gli f
            Console.WriteLine(x);
            int y = 1;
            float zz = x + y;
            Console.WriteLine(zz);
        }
    }
}
