﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipi_generici_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ComparatoreDiItem comparatorediitem = new ComparatoreDiItem();
            Console.WriteLine("Ricerca cateogrial: ");
            string categoria = Console.ReadLine();
            Console.WriteLine("Inserici il nome dello/a " + categoria + " da ricercare: ");
            string ItemDaRicercare = Console.ReadLine();
            List<string> Item = new List<string>();
            Item.Add("A");
            Item.Add("B");
            Item.Add("C");
            Item.Add("D");
            bool presente = false;
            for (int i = 0; i < Item.Count; i++)
            {
                presente = comparatorediitem.ItemNelDeposito<string>(ItemDaRicercare, Item[i]);
                if (presente)
                {
                    break;
                }
            }
            if (presente)
            {
                Console.WriteLine("L'Item è presente nel deposito");
            } 
            else
            {
                Console.WriteLine("L'Item NON è presente nel deposito");
            }
        }
    }
    public class ComparatoreDiItem
    {
        public bool ItemNelDeposito<T>(T valore1, T valore2)
        {
            return valore1.Equals(valore2);
        }
    }
}
