﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //SuperClasse tutoril2 = new SuperClasse();
            //tutoril2.MetodoA();

            //SottoClsseUno tutorial = new SottoClsseUno();
            //tutorial.MetodoA();
            SuperClasse[] tutorialOverride = new SuperClasse[3];
            tutorialOverride[0] = new SuperClasse();
            tutorialOverride[1] = new SottoClsseUno();
            tutorialOverride[2] = new SottoClsseDue();
            //tutorialOverride[0].MetodoA();
            //tutorialOverride[1].MetodoA();
            //tutorialOverride[2].MetodoA();

            foreach (var item in tutorialOverride)
            {
                item.MetodoA();
            }
        }
    }
    class SuperClasse
    {
        protected int variabile = 10;
        public virtual void MetodoA()
        {
            variabile = variabile + 5;
            Console.WriteLine(variabile);
        }
    }
    class SottoClsseUno : SuperClasse
    {
        public override void MetodoA()
        {
            variabile = variabile + 100;
            Console.WriteLine(variabile);
        }
    }
    class SottoClsseDue : SuperClasse
    {
        public override void MetodoA()
        {
            variabile = variabile + 1000;
            Console.WriteLine(variabile);
        }
    }
}