﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacce
{
    class Program
    {
        static void Main(string[] args)
        {
            CasaMia casamia = new CasaMia();
            casamia.Ingresso();
            casamia.Cucina();
            casamia.Bagno();
            casamia.Piani();
        }
    }
    public interface Architettura
    {
        void TipoDiArchitettura();
    }
    public class Palazzo
    {
        int piani = 10;
        public void Piani()
        {
            Console.WriteLine($"il palazzo ha ben {piani} piani");
        }
    }
    public interface StrutturaDiCasa : Architettura
    {
        void Ingresso();
        void Cucina();
        void Bagno();
    }
    public class CasaMia : Palazzo, StrutturaDiCasa
    {
        public void Ingresso()
        {
            Console.WriteLine("Ingresso grande 5mq");
        }
        public void Cucina()
        {
            Console.WriteLine("Cucina grande 5mq");
        }
        public void Bagno()
        {
            Console.WriteLine("Bagno grande 5mq");
        }
        public void TipoDiArchitettura()
        {
            Console.WriteLine("Architettura : Gotica");
        }
    }
}
