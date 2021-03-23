using System;

namespace Lab2
{
    //Classe de teste
    class Program
    {
        static void Main(string[] args)
        {
            Corrente bn = new Corrente("Bob Nelson", 123456);
            Poupanca tr = new Poupanca("Testolfo Rocha", 717171);
            Corrente ll = new Corrente("Lisa Leite", 654321);
            Console.WriteLine("Contas:");
            ResultadoContas();

            bn.Depositar(5000);
            ll.Depositar(2000);
            tr.Depositar(1500);
            bn.Transferir(tr, 600);
            ll.Sacar(250);
            ll.Transferir(tr, 400);
            tr.Transferir(bn, 1000);
            bn.Sacar(900);
            bn.Transferir(ll, 1500);
            tr.Transferir(ll, 1200);
            bn.Sacar(2000);
            ll.Depositar(100);
            tr.Transferir(bn, 700);


            Console.WriteLine("Contas após operações:");
            ResultadoContas();

            Console.ReadLine();


            void ResultadoContas()
            {
                bn.VerificarSaldo();
                tr.VerificarSaldo();
                ll.VerificarSaldo();
            }

        }
    }
}
