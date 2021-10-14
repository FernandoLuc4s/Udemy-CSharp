using System;

namespace DateTimeKindEPadrãoISO8601
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local); // instanciando uma data no horário local

            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc); // instanciando uma data no horário padrão

            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("d1: "+d1);
            Console.WriteLine("d1 kind: "+d1.Kind);
            Console.WriteLine("d1 to local: "+d1.ToLocalTime()); // converte em horário local
            Console.WriteLine("d1 to utc: "+d1.ToUniversalTime()); // converte em horário universal
            Console.WriteLine();                                                 // deve sempre inserir no banco universalmente e quando ele retornar converter para local
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 kind: " + d2.Kind);
            Console.WriteLine("d2 to local: " + d2.ToLocalTime()); // converte em horário local
            Console.WriteLine("d2 to utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 kind: " + d3.Kind);
            Console.WriteLine("d3 to local: " + d3.ToLocalTime()); // converte em horário local
            Console.WriteLine("d3 to utc: " + d3.ToUniversalTime());
            
            Console.WriteLine();
            Console.WriteLine("ISO8601");
            Console.WriteLine();

            DateTime dt1 = DateTime.Parse("2000-08-15 13:05:58"); // data no formato UTC
            DateTime dt2 = DateTime.Parse("2000-08-15T13:05:58Z"); // já gera o horário local
            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
            Console.WriteLine();
            Console.WriteLine("dt1: " + dt1);
            Console.WriteLine("dt1 kind: " + dt1.Kind);
            Console.WriteLine("dt1 to local: " + dt1.ToLocalTime()); // converte em horário local
            Console.WriteLine("dt1 to utc: " + dt1.ToUniversalTime()); // converte em horário universal
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("dt2: " + dt2);
            Console.WriteLine("dt2 kind: " + dt2.Kind);
            Console.WriteLine("dt2 to local: " + dt2.ToLocalTime()); // converte em horário local
            Console.WriteLine("dt2 to utc: " + dt2.ToUniversalTime()); // converte em horário universal
            Console.WriteLine();
            Console.WriteLine(dt2.ToString("yyyy-MM-ddTHH:mm:ssz")); // cuidado! passando com o padrão iso, mas primeiro deve converter ela para universal e depois realizar o tostring
            Console.WriteLine(dt2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssz"));
        }
    }
}
