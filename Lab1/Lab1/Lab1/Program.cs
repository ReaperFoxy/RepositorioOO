using System;

namespace Lab1
{
    class Program
    {
        string nome;
        int idade;
        float altura;
        float peso;
        

        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao cálculo de IMC! Por favor, insira as seguintes informações:");
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();       
            
            Console.WriteLine("Idade:");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Altura (em metros. Ex: 1,60):");
            float altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Peso(Kg):");
            float peso = float.Parse(Console.ReadLine());


            float imc = CalcularImc(altura, peso);
            Console.WriteLine(imc.ToString());
            float meta = CalcularMeta(imc, altura);

            if (imc>18.5 && imc<24.5)
            {
                Console.WriteLine("Parabéns — você está em seu peso normal! Seu IMC é de " + imc.ToString()); 
            }
            else if (imc>25 && imc< 29.9)
            {
                Console.WriteLine("Você está acima de seu peso (sobrepeso). Seu IMC é de " + imc.ToString());
                Console.WriteLine("Sua meta de peso máximo é de: " + meta.ToString() + "Kg");
            }
            else if (imc > 30 && imc < 34.9)
            {
                Console.WriteLine("Obesidade grau I. Seu IMC é de " + imc.ToString());
                Console.WriteLine("Sua meta de peso máximo é de: " + meta.ToString() + "Kg");
            }
            else if (imc > 35 && imc < 39.9)
            {
                Console.WriteLine("Obesidade grau II. Seu IMC é de " + imc.ToString());
                Console.WriteLine("Sua meta de peso máximo é de: " + meta.ToString() + "Kg");
            }
            else if (imc >= 40)
            {
                Console.WriteLine("Obesidade graus III e IV. Seu IMC é de " + imc.ToString());
                Console.WriteLine("Sua meta de peso máximo é de: " + meta.ToString() + "Kg");
            }
            else if (imc <= 18.5)
            {
                Console.WriteLine("Se cuida, você está abaixo do peso saudável. Seu IMC é de " + imc.ToString());
                Console.WriteLine("Sua meta de peso máximo é de: " + meta.ToString() + "Kg");
            }

        }

        public static float CalcularImc(float altura, float peso)
        {
            return peso / (altura * altura);

        }

        public static float CalcularMeta(float imc, float altura)
        {
             
            float imcIdeal = 24;
            float meta = imcIdeal * (altura * altura);

            return meta;
        }


/*
Entre 18,5 e 24,9
Parabéns — você está em seu peso normal!
Entre 25,0 e 29,9
Você está acima de seu peso (sobrepeso).
Entre 30,0 e 34,9
Obesidade grau I.
Entre 35,0
Obesidade grau II.
40,0 e acima
Obesidade graus III e IV.

*/



    }
}
