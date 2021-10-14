using System;
using ExercResolvido01.Entities.Enums;
using ExercResolvido01.Entities;
using System.Globalization;

namespace ExercResolvido01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string dptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Departament dept = new Departament(dptName);
            Worker worker = new Worker (name, level, baseSalary, dept);
            Console.Write("how many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i}contract data");
                Console.Write("Date (DD/MM/YYYY)");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour:");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours)");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);

                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Enter month and uear to calculate income (MM/YYYY)");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2)); // pegar os 2 primeiros caracteres a partir do Mês
            int year= int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: "+worker.Name);
            Console.WriteLine("Departament: "+worker.Departament.Name);
            Console.WriteLine("Income for "+monthAndYear+": "+worker.Income(year, month));
        }
    }
}
