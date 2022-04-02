using System;
using System.IO;

namespace FileFileInfoeIOException
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\User\OneDrive\Área de Trabalho\udemy\C#\Seção 13 Trabalhando com arquivos\testes\file1.txt";
            string targetPath = @"C:\Users\User\OneDrive\Área de Trabalho\udemy\C#\Seção 13 Trabalhando com arquivos\testes\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath); // ler todas as linhas e guardar

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
               
            }
            catch (IOException e) {
                Console.WriteLine("An erros ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
