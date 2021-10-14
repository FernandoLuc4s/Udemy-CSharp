using System;

namespace PropriedadesEOperaçõesComDate_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);

            Console.WriteLine("1) Date: "+d.Date ); // imprimindo a data como um todo e desconsiderar o horário
            Console.WriteLine("2) Day: " +d.Day); // pega o dia
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek); // dia da semana
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear); // dia do ano
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind); // tipo
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) ticks: " + d.Ticks); // quantidade de ticks
            Console.WriteLine("12) timeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);
            
            Console.WriteLine();
            Console.WriteLine("Date Time com Formatação");
            Console.WriteLine();

            DateTime d1 = new DateTime(2001, 8, 15, 13, 45, 58);

            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();
            string s5 = d.ToString();

            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff"); 

            Console.WriteLine(s1); // imprimir data de uma maneira mais longa e completa
            Console.WriteLine(s2); // imprimi o horário
            Console.WriteLine(s3); // imprimi data no formato resumido
            Console.WriteLine(s4); // imprimi o horário no formato resumido
            Console.WriteLine(s5); // imprimi no formato padrão
            Console.WriteLine(s6); // imprimindo data com uma mascara
            Console.WriteLine(s7); // imprimindo uma mascara com milisegundos

            Console.WriteLine();
            Console.WriteLine("Date Time com Operações");
            Console.WriteLine();


            DateTime d2 = new DateTime(2001, 8, 15, 13, 45, 58);

            DateTime d3 = d.AddHours(2); // acrescentando valores a data
            DateTime d4 = d.AddMinutes(3);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            DateTime d5 = DateTime.Now;

            DateTime d6 = d5.AddDays(7);
            Console.WriteLine(d5);
            Console.WriteLine(d6);

            DateTime data2 = new DateTime(2001, 10, 15);
            DateTime data3 = new DateTime(2001, 10, 18);
            TimeSpan t = data3.Subtract(data2); // subtrai a data 

            Console.WriteLine(t);

        }
    }
}
