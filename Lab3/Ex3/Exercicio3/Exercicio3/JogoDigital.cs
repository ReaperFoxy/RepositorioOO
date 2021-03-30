﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3
{
    class JogoDigital : Produto
    {
        public JogoDigital(string titulo, double preco, string plataforma) : base(titulo, preco)
        {
            Plataforma = plataforma;
        }

        public string Console { get; private set; }
        

        public override void InformarDescricao()
        {
            Console.WriteLine($"{Titulo} para {Plataforma}");
        }


    }
}
