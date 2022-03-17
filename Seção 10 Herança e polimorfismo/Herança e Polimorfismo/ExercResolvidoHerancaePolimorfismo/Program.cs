using System;
using System.Collections.Generic;
using ExercResolvidoHerancaePolimorfismo.Entities;
using System.Globalization;

namespace ExercResolvidoHerancaePolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Employee #"+i+" data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(additionalCharge, name, hours, valuePerHour));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
