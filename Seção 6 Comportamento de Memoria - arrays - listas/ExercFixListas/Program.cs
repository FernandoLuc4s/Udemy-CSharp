using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercFixListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionarios> func = new List<Funcionarios>();
            Console.WriteLine("How many employees will be registered? ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Employee #" + (i + 1));
                Console.WriteLine("id");
                int cod = int.Parse(Console.ReadLine());
                Console.WriteLine("name");
                string name = Console.ReadLine();
                Console.WriteLine("salary");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                func.Add(new Funcionarios(cod, name, salary));

            }
            Console.WriteLine("Enter the employyee id that will have salary increment");
            int searchId = int.Parse(Console.ReadLine());

            Funcionarios emp = func.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.WriteLine("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IcreasySalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine();
            foreach (Funcionarios obj in func)
            {
                Console.WriteLine("Updated list of employees: ");
                Console.WriteLine(obj);
            }
        }
    }
}
