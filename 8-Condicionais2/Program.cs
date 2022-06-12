using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idade = 68;
            bool ehIdoso = idade >= 65;

            Console.WriteLine(ehIdoso);

            /*  int idade = 16;
              // int quantidadePessoa = 2;

              //bool acompanhado = quantidadePessoa >= 2;
              bool acompanhado = true;

              if (idade >= 18 && acompanhado == true) 
              {
                  Console.WriteLine("Pode entrar! ");
              }

              else

              {
                  Console.WriteLine("Não pode entrar");
              }

              */

            Console.ReadLine();
        }
    }
}
