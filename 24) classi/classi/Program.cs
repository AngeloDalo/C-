using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classi
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasseDiProva riferementoOggettoUno = new ClasseDiProva();
            riferementoOggettoUno.Nome = "Mario";
            riferementoOggettoUno.Cognome = "Rossi";
            riferementoOggettoUno.Media = 10;

            ClasseDiProva riferementoOggettoDue = new ClasseDiProva();
            riferementoOggettoUno.Nome = "Franco";
            riferementoOggettoUno.Cognome = "Ceccio";
            riferementoOggettoUno.Media = 8;

            Console.WriteLine(riferementoOggettoUno.Nome);
        }
    }
}
