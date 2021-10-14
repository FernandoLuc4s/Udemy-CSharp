using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a contação do dolar ? ");
            ConversaoDeMoeda.Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares você vai comprar ? ");
            ConversaoDeMoeda.Dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = "+ConversaoDeMoeda.Resultado().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
