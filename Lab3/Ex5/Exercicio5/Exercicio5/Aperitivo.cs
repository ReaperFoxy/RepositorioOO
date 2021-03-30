using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio5
{
    class Aperitivo : ItemMenu
    {
        public Aperitivo(string nome, double preco) : base(nome,preco)
        {
           
        }

        public void ImprimirPreco()
        {
            base.ImprimirPreco();
        }

    }
}
