using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("praticando do Switch");

        int mes = 6;

        switch (mes)
        {
            case 1:
                Console.WriteLine("O Mês é Janeiro");
                break;

                case 2:
                Console.WriteLine("O Mês é Fevereiro");
                break;

            case 3:
                Console.WriteLine("O Mês é Março");
                break;

            case 4:
                Console.WriteLine("O Mês é Abril");
                break;

            case 5:
                Console.WriteLine("O Mês é Maio");
                break;

            case 6:
                Console.WriteLine("O Mês é Junho");
                break;

            case 7:
                Console.WriteLine("O Mês é Julho");
                break;

            case 8:
                Console.WriteLine("O Mês é Agosto");
                break;

            case 9:
                Console.WriteLine("O Mês é Setembro");
                break;

            case 10:
                Console.WriteLine("O Mês é Outubro");
                break;

            case 11:
                Console.WriteLine("O Mês é Novembro");
                break;

            case 12:
                Console.WriteLine("O Mês é Dezembro");
                break;

                default:
                Console.WriteLine("Mês Inválido");
                break;

        }
        Console.WriteLine("Pressione enter para finalizar...");
        Console.ReadLine();
    }
}

