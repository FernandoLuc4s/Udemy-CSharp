using System;

namespace PalavraVar
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 10; // O C# é capaz de inferir o valor das variaveis
            var y = 20.0;
            var z = "Maria";

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
