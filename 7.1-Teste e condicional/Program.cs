using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_Teste_e_condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando as condicionais 7.1 ");

            int idade = 18;
            int quantidadePessoas = 3;

            if (idade >= 18)
            {
                Console.WriteLine("Você tem mais de 18 anos ");
                Console.WriteLine("Seja Bem Vindo ao mundo magico de OZ");
            }
            else
            {

                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Você é menor de idade, mas esta acompanhado, pode entrar");

                }

                else
                {
                    Console.WriteLine("Infelizmente você não possui a idade mimima para o evento");
                }

            }

            Console.ReadLine();
        }
    }
}
