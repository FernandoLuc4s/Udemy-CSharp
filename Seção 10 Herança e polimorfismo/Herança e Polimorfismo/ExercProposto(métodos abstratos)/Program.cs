using System;
using System.Globalization;
using System.Collections.Generic;
using ExercProposto_metodos_abstratos_.Entities;

namespace ExercProposto_metodos_abstratos_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            double totalTax=0.0;

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                if (ch == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(healthExpenditures, name, anualIncome));
                }
                else 
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Company(numberOfEmployees, name, anualIncome));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer tax in list)
            {
                Console.WriteLine(tax.Name + ": $ " + tax.Tax().ToString("F2", CultureInfo.InvariantCulture));
                totalTax += tax.Tax();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ "+totalTax.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
