using System;

namespace ExercResolvidoMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n,n];

            for (int i = 0; i < n; i++) // percorre as linhas
            {
                string[] values = Console.ReadLine().Split(' '); // pega a linha e recortar ele no espaço em branco
                for (int j = 0; j < n; j++)// percorre a coluna
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("main diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i] + " ");
            }
            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0) 
                    {
                        count++;
                    }
                }
            }
            Console.Write("negative numbers: " +count);
        }
    }
}
