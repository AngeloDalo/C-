using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classi
{
    class ClasseDiProva
    {
        public string nome;
        private string cognome;
        int media;
        //GET eseguito al momento della lettura, esso prende il valore della varibile
        //SET eseguito al momento della scrittura, esso viene eseguito quanto viene
        //    assegnato un NUOVO valore alla varibile
        //GET E SET NON sono classificabili come varibili, NON è quindi possibile
        //passare come riferimento "REF" o "OUT"
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Cognome
        {
            get { return cognome; }
            set { cognome = value; }
        }
        public int Media
        {
            get { return media; }
            set { media = value; }
        }
    }
}
