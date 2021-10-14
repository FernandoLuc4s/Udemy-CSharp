using System;

namespace PropriedadesEOperacoesComTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = TimeSpan.MaxValue; // pega o valor maximo do time span
            TimeSpan t2 = TimeSpan.MinValue; // pega o valor minimo do time span
            TimeSpan t3 = TimeSpan.Zero; // pega o valor zero do time span

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            Console.WriteLine();
            Console.WriteLine("Propriedades");
            Console.WriteLine();

            TimeSpan t = new TimeSpan(2 , 3, 5, 7, 11);
            Console.WriteLine(t);

            Console.WriteLine("Days: "+t.Days); // essas devolvem o número inteiro
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);

            Console.WriteLine("TotalDays: "+t.TotalDays); // e aqui o numero quebrado
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

            Console.WriteLine();
            Console.WriteLine("Operações");
            Console.WriteLine();

            TimeSpan ts1 = new TimeSpan(1, 30, 10);
            TimeSpan ts2 = new TimeSpan(0, 10, 5);
            

            TimeSpan sum = ts1.Add(ts2); // somando o ts1 com o ts2
            TimeSpan dif = ts1.Subtract(ts2); // subtraindo
            TimeSpan mult = ts2.Multiply(2.0); // multiplicando
            TimeSpan div = ts2.Divide(2.0);

            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }

    }
}
