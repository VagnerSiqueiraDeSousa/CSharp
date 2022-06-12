using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 7. condicionais");

            int idade = 16;
            int quantidadePessoa = 2;

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade, pode entrar ");
            }
            else
            {
                if (quantidadePessoa >= 2)
                {
                    Console.WriteLine(" vc é menor mas esta acompanhado por um maior, pode entrar");
                }

                else
                {
                    Console.WriteLine("ops vc e menor de idade, não pode entrar");
                }


            }




            Console.WriteLine("Pressione enter para Sair . . .");
            Console.ReadLine();
        }
    }
}
