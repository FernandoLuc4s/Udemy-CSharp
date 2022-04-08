using System;
using System.IO;

namespace BlocoUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\Users\User\OneDrive\Área de Trabalho\udemy\C#\Seção 13 Trabalhando com arquivos\testes\file1.txt";
                // using =  fecha bloco após ser executado
                using (StreamReader sr =  File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
