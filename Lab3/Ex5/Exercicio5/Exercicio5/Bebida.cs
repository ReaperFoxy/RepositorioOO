using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio5
{
    class Bebida:ItemMenu
    {
        public string TamanhoBebida { get; set; }
        public Bebida(string nome, double preco) : base(nome, preco)
        {
        }

        public override void ImprimirPreco() 
        {

            double precoP = Preco * 0.8;
            double precoM = Preco;
            double precoG = Preco * 1.5;

            Console.WriteLine("{0} P..... {1}", Nome, precoP);
            Console.WriteLine("{0} M..... {1}", Nome, precoM);
            Console.WriteLine("{0} G..... {1}", Nome, precoG);

        }
    }
}