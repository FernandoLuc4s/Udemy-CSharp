using System;

namespace Time_Span
{
    class Program
    {
        static void Main(string[] args)
        {
            // representa uma duração na forma de ticks(100 nanosegundos)

            TimeSpan t1 = new TimeSpan(0, 1, 30); // pega os minustos e segundos        
            TimeSpan t2 = new TimeSpan(900000000L); // pega os ticks e converte em uma duração
            TimeSpan t3 = new TimeSpan(1,2,11,21);// dia, data e hora
            TimeSpan t5 = new TimeSpan(1,2,11,21,321);// dia data hora e milisegundos

            Console.WriteLine();
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t5);
            Console.WriteLine();
            Console.WriteLine("Utilizando o Metodo From");
            Console.WriteLine();
            TimeSpan tf1 = TimeSpan.FromDays(1.5); // você pode converter da forma que quiser inclusive com numeros quebrados
            TimeSpan tf2 = TimeSpan.FromHours(1.5); // coverte em hora
            TimeSpan tf3 = TimeSpan.FromMinutes(1.5); // converte em minutos
            TimeSpan tf4 = TimeSpan.FromSeconds(1.5); // converte em segundos
            TimeSpan tf5 = TimeSpan.FromMilliseconds(1.5); // converte em milisegundos
            TimeSpan tf6 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(tf1);
            Console.WriteLine(tf2);
            Console.WriteLine(tf3);
            Console.WriteLine(tf4);
            Console.WriteLine(tf5);
            Console.WriteLine(tf6);
        }
    }
}
