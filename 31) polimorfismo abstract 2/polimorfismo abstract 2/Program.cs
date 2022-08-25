using System;
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
            SuperClasse[] tutorialOverride = new SuperClasse[2];
            //tutorialOverride[0] = new SuperClasse(); //non posso chiamare classe astratta
            tutorialOverride[0] = new SottoClsseUno();
            tutorialOverride[1] = new SottoClsseDue();
            //tutorialOverride[0].MetodoA();
            //tutorialOverride[1].MetodoA();
            //tutorialOverride[2].MetodoA();

            foreach (var item in tutorialOverride)
            {
                item.MetodoA();
                item.MetodoAbs();
            }
        }
    }
    abstract class SuperClasse
    {
        protected int variabile = 10;
        public abstract void MetodoAbs();
        public virtual void MetodoA()
        {
            variabile = variabile + 5;
            Console.WriteLine(variabile);
        }
    }
    class SottoClsseUno : SuperClasse
    {
        public override void MetodoAbs()
        {
            Console.WriteLine("ciao");
        }
        public override void MetodoA()
        {
            variabile = variabile + 100;
            Console.WriteLine(variabile);
        }
    }
    class SottoClsseDue : SuperClasse
    {
        public override void MetodoAbs()
        {
            Console.WriteLine("ciao2");
        }
        public override void MetodoA()
        {
            variabile = variabile + 1000;
            Console.WriteLine(variabile);
        }
    }
}
