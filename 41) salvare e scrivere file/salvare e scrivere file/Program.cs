using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salvare_e_scrivere_file
{
    class Program
    {
        static void Main(string[] args)
        {
            //Directory.CreateDirectory(@"C:\Users\angel\OneDrive\Desktop\boolean\07)C#\41) salvare e scrivere file);
            string fileTutorial = @"C:\Users\angel\OneDrive\Desktop\boolean\07)C#\41) salvare e scrivere file\Tutorial.txt";
            StreamWriter streamwriter = new StreamWriter(fileTutorial, true);
            //true non fa creare un nuovo file ogni volta che faccio debug ma aggiunge nuove righe
            streamwriter.WriteLine("Tizio");
            streamwriter.WriteLine("Caio");
            streamwriter.Close();
        }
    }
}
