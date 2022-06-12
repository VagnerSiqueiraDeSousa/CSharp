using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9, Escopo");

            int idade = 18;
            bool acompanhado = false;
            string mensagemAdicional;

            if (acompanhado == true)
            {
               mensagemAdicional = "Joao esta acompanhado! ";

                Console.WriteLine(mensagemAdicional);
                }

            else
            {
                mensagemAdicional = "Joao não esta acompanhado !";
                Console.WriteLine(mensagemAdicional);
            }


            if (idade >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar! ");
                Console.WriteLine(mensagemAdicional);
            }

            else

            {
                Console.WriteLine("Não pode entrar");
            }



            Console.ReadLine();
        }
    }
}

