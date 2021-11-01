using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];// indica que está criando um arranjo bidimencional

            Console.WriteLine(mat.Length); // quantos elementos a matriz tem no total

            Console.WriteLine(mat.Rank); // quanto é a quantidade de linhas

            Console.WriteLine(mat.GetLength(0)); // ele fala que a primeira dimensão tem tamanho 2

            Console.WriteLine(mat.GetLength(1)); //ele fala que a primeira dimensão tem tamanho 3
        }
    }
}
