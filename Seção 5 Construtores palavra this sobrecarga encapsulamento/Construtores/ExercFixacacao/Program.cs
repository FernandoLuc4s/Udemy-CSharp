using System;
using System.Globalization;


namespace ExercFixacacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposito;
            double saque;

            Console.Write("Entre o numero da conta: ");
            int numConta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre o titular da conta: ");
            string titularConta = Console.ReadLine();
            Console.Write("Haverá de pósito inicial (s/n)?: ");
            string opc = Console.ReadLine();
            if (opc=="S" || opc=="s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                ContaBancaria c = new ContaBancaria(numConta, titularConta, deposito);
                Console.WriteLine("dados da conta");
                Console.WriteLine(c);

                Console.WriteLine();

                Console.Write("Entre um valor para depósito: ");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c.AdicionarSaldo(deposito);
                Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine(c);
                Console.WriteLine();
                Console.Write("Entre um valor para saque: ");
                saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                c.RemoverSaldo(saque);
                Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine(c);
            }
            else
            {
                ContaBancaria c2 = new ContaBancaria(numConta, titularConta);
                Console.WriteLine("dados da conta");
                Console.WriteLine(c2);
                Console.WriteLine();
                Console.Write("Entre um valor para depósito: ");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c2.AdicionarSaldo(deposito);
                Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine(c2);
                Console.WriteLine();
                Console.Write("Entre um valor para saque: ");
                saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                c2.RemoverSaldo(saque);
                Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine(c2);
            }
        }
    }
}
