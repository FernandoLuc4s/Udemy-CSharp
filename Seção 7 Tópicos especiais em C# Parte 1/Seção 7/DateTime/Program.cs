using System;
using System.Globalization;
namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks); // quantidade de ticks(100 nanosegundos) que já passaram desde janeiro da era comum até agora
            Console.WriteLine();
            Console.WriteLine("Construtores do DateTime");

            DateTime d2 = new DateTime(2018, 11, 25); // imprimindo esse dia ás 0 horas
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3); // imprimindo esse dia ás 20:15:3 horas
            DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 3, 500); // imprimindo esse dia ás 20:15:3 horas e os milisegundos



            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            Console.WriteLine("Builders do datetime");

            DateTime d5 = DateTime.Now;
            DateTime d6 = DateTime.Today;// imprime na data de hoje e nas 0 horas
            DateTime d7 = DateTime.UtcNow; // horário de agora mas no Grenwich ou seja no horario universal

            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine("Utilizando o Parse");
            Console.WriteLine();

            DateTime data1 = DateTime.Parse("2000-08-15");
            DateTime data2 = DateTime.Parse("2000-08-15 13:05:58");

            DateTime data3 = DateTime.Parse("15/08/2000");
            DateTime data4 = DateTime.Parse("15/08/2000 13:05:58"); // converte a string em data



            Console.WriteLine(data1);
            Console.WriteLine(data2);
            Console.WriteLine(data3);
            Console.WriteLine(data4);
            Console.WriteLine();
            Console.WriteLine("Utilizando o parse exact");
            Console.WriteLine();

            DateTime dataPerson = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture); // formata o datetime da maneira que você deseja utilizando uma mascacara
            DateTime dataPerson2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(dataPerson);
            Console.WriteLine(dataPerson2);
        }
    }
}
