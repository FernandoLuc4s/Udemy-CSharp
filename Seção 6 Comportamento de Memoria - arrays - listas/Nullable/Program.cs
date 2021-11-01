using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable<double> x = null; // declarando um double nul

            //double? x = null;
            //double? y = 10.0;

            //Console.WriteLine(x.GetValueOrDefault()); // pega o valor de X se não tiver pega o valor padrão
            //Console.WriteLine(y.GetValueOrDefault());

            //Console.WriteLine(x.HasValue); // vai dizer se na variável x tem um valor
            //Console.WriteLine(y.HasValue);

            //if (x.HasValue)
            //{
            //    Console.WriteLine(x.Value); // pega o valor diretamente da variavel

            //}
            //else {
            //    Console.WriteLine("X is null");
            //}


            //if (y.HasValue)
            //{
            //    Console.WriteLine(y.Value); // pega o valor diretamente da variavel

            //}
            //else
            //{
            //    Console.WriteLine("Y is null");
            //}

            double? x = null;
            double? y = 10;
            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
