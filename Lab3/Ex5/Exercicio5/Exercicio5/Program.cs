using System;

namespace Exercicio5
{
    class Program
    {
        const double precoAperitivo = 10;


        static void Main(string[] args)
        {
            ItemMenu bebida1 = new Bebida("Água", 5);
            ItemMenu bebida2 = new Bebida("Refrigerante", 7.5f);
            ItemMenu bebida3 = new Bebida("Suco natural", 8);

            ItemMenu aperitivo1 = new Aperitivo("Empada", precoAperitivo);
            ItemMenu aperitivo2 = new Aperitivo("Coxinha", precoAperitivo);

            ItemMenu[] menu = { aperitivo1, aperitivo2, bebida1, bebida2, bebida3 };

            foreach(ItemMenu item in menu)
            {
                item.ImprimirNome();
                item.ImprimirPreco();
                Console.WriteLine("--------------------");
               
            }


        }
    }
}
