using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace read_line_e_parse
{
    class Program
    {
        static void Main(string[] args)
        {
            //readline e parse
            string nome, cognome, soprannome;
            Console.WriteLine("Ciao, qual'è il tuo nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Ed il tuo cognome?");
            cognome = Console.ReadLine();
            Console.WriteLine("Ed il tuo soprannome?");
            soprannome = Console.ReadLine();
            Console.WriteLine("Ciao " + nome + " " + cognome + " conosciuto anche come: " + soprannome + ", io mi chiamo Bot"); //primo metodo
            Console.WriteLine("Ciao {0} {1} conosciuto anche come :{2}, io mi chiamo Bot", nome, cognome, soprannome); //secondo metodo
            Console.WriteLine($"Ciao, {nome} {cognome}, conosciuto anche come: {soprannome}, io mi chiamo Bot"); //terzo metodo

            //parse è per i numeri
            Console.WriteLine("Quanti anni hai?");
            int numeroIntero = int.Parse(Console.ReadLine());
            Console.WriteLine("Hai scelto il numero: " + numeroIntero);

            Console.WriteLine($"{nome} scegli un numero con la virgola: ");
            float numeroVirgola = float.Parse(Console.ReadLine());
            Console.WriteLine("Hai scelto il numero: " + numeroVirgola);
        }
    }
}
