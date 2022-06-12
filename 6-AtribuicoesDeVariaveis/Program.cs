using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Oi Vagner, estamos Executando o projeto 6");

            int idade = 38;
            int idadeVagner = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeVagner);

            



            Console.WriteLine("Presseione a enter para Sair . . . ");
            Console.ReadLine();
        }
    }
}
