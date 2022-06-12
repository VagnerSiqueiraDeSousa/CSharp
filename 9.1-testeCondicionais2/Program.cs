using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1_testeCondicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 9. teste de codicionais 2");
            Console.WriteLine("");

            int idade = 18;
            int quantidadePessoa = 3;
            bool acompanhado = quantidadePessoa >= 2;


            if (idade >= 18 && acompanhado)
            {
                Console.WriteLine("Seja Bem Vindo! ");
            }

            else
            {
                Console.WriteLine("Infelimente você não pode entra !");
            }



            Console.WriteLine("");
            Console.WriteLine("Pressione o entre para finalizar o programa");
            Console.ReadLine();
        }
    }
}
