using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //utilizzati per passare metodi come argomenti ad altri metodi, sono puntatori che non rappresentano
            //un valore, ma un metodo
            Tutorial tutorial = new Tutorial();
            string risposta;
            PrimoDelegato varPrimoDel = tutorial.MarioRossi;
            //risposta = varPrimoDel(10, 18);
            //Console.WriteLine(risposta);
            varPrimoDel += tutorial.TizianoCaioi;
            Console.WriteLine(varPrimoDel(10, 18));
        }
    }
    public delegate string PrimoDelegato(int anni, int maggiorenne);
    public class Tutorial 
    {
        public string MarioRossi(int anni, int maggiorenne)
        {
            string eta;
            if (anni > maggiorenne)
            {
                eta = "Maggiorenne";
            }
            else
            {
                eta = "Minorenne";
            }
            return eta;
        }
        public string TizianoCaioi(int anni, int maggiorenne)
        {
            string eta;
            if (anni > maggiorenne)
            {
                eta = "Maggiorenne";
            }
            else
            {
                eta = "Minorenne";
            }
            return eta;
        }
    }
}
