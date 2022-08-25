using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_action
{
    class Program
    {
        static void Main(string[] args)
        {
            //necessita di un metodo vuoto
            Program program = new Program();
            Action ActionNoParametri = program.MeotodoSenzaParametri;
            Action<int, string, bool> ActionConParametri = program.MeotdoConParametri;
            //metodo senza parametri
            //ActionNoParametri = program.MeotodoSenzaParametri;
            ActionNoParametri();
            //metodo con parametri
            //ActionConParametri = program.MeotdoConParametri;
            ActionConParametri(10, "Action", true);
        }
        public void MeotodoSenzaParametri()
        {
            int z = 0;
            Console.WriteLine("Metodo senza parametro" + z);
        }
        public void MeotdoConParametri(int intero, string stringa, bool booleriana)
        {
            int operazione = 0;
            if (stringa == "Action")
            {
                if (booleriana)
                {
                    operazione = intero;
                }
            }
            Console.WriteLine("Metodo con parametro");

        }
    }
}
