using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classi_parziali
{
    class Program
    {
        static void Main(string[] args)
        {
            //viene situata du 2 o più file diversi.
            //si usano proprio qunado abbiamo necessità di creare più file
            //ma tutti funzionano con una singola classe
            ClasseParziale classeparziale = new ClasseParziale();
            Console.WriteLine(classeparziale.total());
        }
    }
    public partial class ClasseParziale
    {
        int varIntera = 10;
        public int total()
        {
            int totale = varIntera + varInteraDiUnAltroFile;
            return totale;
        }
    }
}
