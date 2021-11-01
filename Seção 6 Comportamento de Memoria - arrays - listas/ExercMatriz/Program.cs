using System;

namespace ExercMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vector = Console.ReadLine().Split(' ');
            int line = int.Parse(vector[0]);
            int col = int.Parse(vector[1]);

            int[,] mat = new int[line, col];


            for (int i = 0; i < line; i++)
            {
                string[] vect = Console.ReadLine().Split(' ');
                for (int j = 0; j < col; j++)
                {
                    mat[i, j] = int.Parse(vect[j]);
                }
            }
            Console.WriteLine();

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < line; i++)
            {

                for (int j = 0; j < col; j++)
                {
                    if (mat[i, j] == num)
                    {
                        Console.WriteLine("Position: " + i + ", " + j);
                        if (j>0)
                        {
                            Console.WriteLine("Left: "+mat[i, j-1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i -1, j]);
                        }
                        if (j < col -1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < line - 1)
                        {
                            Console.WriteLine("Down: " + mat[i +1, j ]);
                        }
                    }

                }
            }

        }
    }
}
