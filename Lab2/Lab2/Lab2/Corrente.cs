using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Corrente : Conta 
    {
        public Corrente(string nome, int nIdentidade)
        {
            this.nome = nome;
            this.nIdentidade = nIdentidade;
            saldo = 0;
        }

        public void Sacar(float sacado)
        {
            Sacar(sacado, 0.0037f);
        }

        public void Transferir(Conta beneficiado, float valor)
        {
            Transferir(beneficiado, valor, 0.001f);

        }

        public void VerificarSaldo()
        {
            ChecarSaldo();
        }

        public void Depositar(float valorDepositado)
        {
            base.Depositar(valorDepositado);
        }

    }
}
