using System;
using System.Globalization;

namespace VetoresDois
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtde = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[qtde];

            for (int i = 0; i < qtde; i++)
            {
                string produto = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Produto { Name = produto, Price = preco };
            }

            double soma = 0;

            for (int i = 0; i < qtde; i++)
            {
                soma += vect[i].Price;
            }

            double avg = soma / qtde;

            Console.WriteLine("AVG = "+avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
