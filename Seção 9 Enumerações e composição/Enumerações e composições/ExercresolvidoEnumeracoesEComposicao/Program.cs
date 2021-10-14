using System;
using ExercresolvidoEnumeracoesEComposicao.Entities.Enums;
using ExercresolvidoEnumeracoesEComposicao.Entities;
using System.Globalization;

namespace ExercresolvidoEnumeracoesEComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament1s name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter Worker data ");
            Console.Write("Name: ");
            string funcName = Console.ReadLine();
            Console.Write("Level (Junio/MidLevel/Senior)");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine()); // converte o que está sendo escrito para enum
            Console.Write("Base salary");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(funcName, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:"); // interpolaçao ou seja mostra a variavel sem precisar de concatenar
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (Hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours); // instanciando o contrato
                worker.AddContract(contract); // adicionando contarto ao trablhador
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income(mm/yyyy): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2)); // recortando a string
            int year = int.Parse(monthAndYear.Substring(3));

            Console.Write("Name: "+worker.Name);
            Console.WriteLine("Departament: "+ worker.Department.Name); // acessando os valores
            Console.WriteLine("income for : "+monthAndYear+": "+worker.Income(year, month));


        }
    }
}
