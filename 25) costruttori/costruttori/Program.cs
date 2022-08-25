using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace costruttori
{
    class Program
    {
        static void Main(string[] args)
        {
            //int vuota = default(int); //0


            ClasseDiProva riferementoOggettoUno = new ClasseDiProva();
            //riferementoOggettoUno.Nome = "Mario";
            riferementoOggettoUno.Cognome = "Rossi";
            riferementoOggettoUno.Media = 10;

            ClasseDiProva riferementoOggettoDue = new ClasseDiProva();
            riferementoOggettoDue.Nome = "Franco";
            //riferementoOggettoDue.Cognome = "Ceccio";
            riferementoOggettoDue.Media = 8;

            Console.WriteLine(riferementoOggettoUno.Nome);
        }
    }
}
