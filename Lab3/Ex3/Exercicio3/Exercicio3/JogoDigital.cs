using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3
{
    class JogoDigital : Produto
    {
        public string Plataforma { get; private set; }

        public JogoDigital(string titulo, double preco, string plataforma) : base(titulo, preco)
        {
            Plataforma = plataforma;
        }
    

        public override void InformarDescricao()
        {
            Console.WriteLine("{0} para {1}", Titulo, Plataforma);
        }


    }
}
