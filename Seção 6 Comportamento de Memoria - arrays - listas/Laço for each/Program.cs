using System;

namespace Laço_for_each
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] {"Maria", "Alex", "BOB "};

            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }
            Console.WriteLine("--------------------------------------------");

            foreach (string obj in vect) // para cada obj no meu vetor eu imprimo eles
            {
                Console.WriteLine(obj);
            }
        }
    }
}
