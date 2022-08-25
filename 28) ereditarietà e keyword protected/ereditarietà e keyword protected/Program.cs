using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ereditarietà_e_keyword_protected
{
    class Program
    {
        static void Main(string[] args)
        {
            //le superclassi cedono le proprie informazioni alle sottoclassi
            //padre e figlio
            //Padre tutorial = new Padre();
            //tutorial.MetodoPadre();
            Figlio tutorial2 = new Figlio();
            tutorial2.MetodoPadre();
            tutorial2.MetodoFiglio();
        }
    }
    class Dna
    {
        protected string coloreOcchi;
        protected string coloreCapelli;
    }
    class Padre : Dna
    {
        protected string cognome = "Rossi";
        private string nome;
        public void MetodoPadre()
        {
            nome = " Mario";
            coloreOcchi = " gli occhi sono marroni";
            Console.WriteLine(cognome + nome + coloreOcchi);
        }
    }
    class Figlio : Padre
    {
        private string nome;
        public void MetodoFiglio()
        {
            nome = " Tiziano";
            coloreOcchi = " gli occhi del figlio sono castani";
            coloreCapelli = " calvo";
            Console.WriteLine(cognome + nome + coloreOcchi + coloreCapelli);
        }
    }
}
