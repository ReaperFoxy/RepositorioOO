using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Poupanca : Conta
    {
        public Poupanca(string nome, int nIdentidade)
        {
            this.nome = nome;
            this.nIdentidade = nIdentidade;
            saldo = 0;
        }

        public void Sacar(float sacado)
        {
            Sacar(sacado, 0.002f);
        }

        public void Transferir(Conta beneficiado, float valor)
        {
            Transferir(beneficiado, valor, 0.0015f);

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
