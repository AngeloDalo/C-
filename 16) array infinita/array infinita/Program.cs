using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_infinita
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInfinita = new int[0];
            int i = 0;
            i++;
            Array.Resize(ref arrayInfinita, i + 1);
            arrayInfinita[0] = 11;
            arrayInfinita[1] = 22;
            Console.WriteLine(arrayInfinita[0]);
            Console.WriteLine(arrayInfinita[1]);
        }
    }
}
