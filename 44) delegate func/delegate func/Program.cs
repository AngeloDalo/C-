using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_func
{
    class Program
    {
        static void Main(string[] args)
        {
            //necessita obbligatoriamente un ritorno
            Func<int> FuncNoParamentri_inMain;
            Func<int, string, bool, int> FuncConParametri_inMain; //ultimo parametro è quello di ritorno
            Program program = new Program();
            FuncNoParamentri_inMain = program.MeotodoSenzaParametri;
            Console.WriteLine(FuncNoParamentri_inMain());
            bool varBool = true;
            FuncConParametri_inMain = program.MeotdoConParametri;
            Console.WriteLine(FuncConParametri_inMain(10, "Func", varBool));
        }
        public int MeotodoSenzaParametri()
        {
            int z = 0;
            return z;
        }
        public int MeotdoConParametri(int intero, string stringa, bool booleriana)
        {
            int operazione = 0;
            if (stringa == "Func")
            {
                if (booleriana)
                {
                    operazione = intero;
                }
            }
            return operazione;
        }
    }
}
