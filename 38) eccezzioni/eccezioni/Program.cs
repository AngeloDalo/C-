using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eccezzioni
{
    class Program
    {
        static void Main(string[] args)
        {
            //try catch finally
            //finally sia se c'è stata un'eccezzione oppure o try andato a buon fine
            int varTuturial1 = 4;
            IniziaDiNuovo:
            int varTutorial2 = Convert.ToInt32(Console.ReadLine());
            double totale = 0;
            //se var2 = 0 da errore
            try
            {
                totale = varTuturial1 / varTutorial2;
                Console.WriteLine("\nDivisione nel try eseguita");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nL'errore è stato : " + e.Message);
                //Console.WriteLine("\nL'errore è stato : " + e.ToString());
                //se try non va a buon fine entro qui
                Console.WriteLine("\nNel cath la variabile totale equivale a : " + totale);
                goto IniziaDiNuovo;
            }
            finally
            {
                Console.WriteLine("\nNel finally la variabile totale equivale a : " + totale);
            }
            Console.WriteLine(totale);
        }
    }
}
