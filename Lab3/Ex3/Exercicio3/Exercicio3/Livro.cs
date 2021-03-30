using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3
{
    class Livro : Produto
    {
        public Livro(string titulo,double preco, string autor) : base(titulo, preco)
        {
            Autor = autor;
        }

        public string Autor { get; private set; }
        public override void InformarDescricao()
        {
            Console.WriteLine($"{0} escrito por {1}", Titulo, Autor);
        }
    }
}
