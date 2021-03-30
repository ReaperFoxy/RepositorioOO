using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio5
{
    class ItemMenu
    {
        public string Nome { get; set; }
        public double Preco { get; }

        public ItemMenu(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }


        public void ImprimirNome()
        {
            Console.WriteLine("{0}", Nome);
        }

        public virtual void ImprimirPreco()
        {
            Console.WriteLine("{0}", Preco);
        }
    }
}
