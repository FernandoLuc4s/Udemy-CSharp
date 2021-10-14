using System;
using System.Globalization;

namespace ExpressaoCondicionalTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;// se o preço for menos que 20 então faz a primeira expresão que é a vedadeira, se não faz a outra que é a falsa
  
            Console.WriteLine(desconto);
        }
    }
}
