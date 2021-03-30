using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3
{
    class Livro : Produto
    {
        public Livro(string titulo, string autor) : base(titulo, autor)
        {
            Autor = autor;
        }

        public string Autor { get; private set; }
        public override void InformarDescricao()
        {
            Console.WriteLine($"{Titulo} escrito por {Autor}");
        }
    }
}
