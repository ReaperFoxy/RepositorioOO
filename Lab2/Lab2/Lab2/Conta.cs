using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Conta
    {
        protected int nIdentidade;
        protected string nome;
        protected float saldo;

        protected void Sacar(float sacado, float imposto)
        {
            if (saldo - (sacado * imposto) > 0)
            {
                sacado -= sacado * imposto;
                saldo -= sacado;
                Console.WriteLine("{0} sacou {1}(imposto incluso) de sua conta. Saldo atual: {2}", nome, sacado, saldo);
            }
            else
            {
                Console.WriteLine("{0} não possui saldo para sacar este valor. Saldo atual: {1}", nome, saldo);
            }

        }

        protected virtual void Depositar(float valorDepositado)
        {
            saldo += valorDepositado;
            Console.WriteLine("{0} adicinou {1} à sua conta.", nome, valorDepositado);
        }

        protected void ChecarSaldo()
        {
            Console.WriteLine("{0} ({1}), seu saldo é de {2}.", nome , nIdentidade, saldo);
        }

        protected void Transferir(Conta beneficiado, float valor, float imposto)
        {
            if(saldo - (valor) > 0)
            {
                saldo -= valor;
                valor -= valor * imposto;
                beneficiado.saldo += valor;
                Console.WriteLine("{0} transferiu {1}(imposto aplicado) para {2}.", nome, valor, beneficiado);
            }
            else
            {
                Console.WriteLine("{0} não possui saldo para transferir este valor. Saldo atual: {1}", nome, saldo);
            }



        }

    }
}
