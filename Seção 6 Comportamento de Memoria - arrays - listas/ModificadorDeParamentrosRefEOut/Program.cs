using System;

namespace ModificadorDeParamentrosRefEOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triple;

            Calculator.Triple( a, out triple);
            Console.WriteLine(triple);

            // ref utiliza para fazer uma referência a variável 
            // out é responsável por guardar um resultado de saída chamado out 
        }
    }
}
