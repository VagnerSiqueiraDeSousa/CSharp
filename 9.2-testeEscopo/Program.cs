using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2_testeEscopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 20;
            int quantidadePessoa = 3;
            bool acompanhado;

            if (quantidadePessoa >= 2)
            {
                 acompanhado = true;
            }

            else
            {
                 acompanhado = false;
            }

            if(idade >= 18 || acompanhado)
            {
                Console.WriteLine("Seja bem vindo!!!");
            }

            else
            {
                Console.WriteLine("Infelizmente você não pode entra !!! :(");
            }

            Console.ReadLine();
        }
    }
}
