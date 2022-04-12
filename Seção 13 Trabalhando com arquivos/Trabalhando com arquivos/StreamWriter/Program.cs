using System;
using System.IO;

namespace AulaStreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\User\OneDrive\Área de Trabalho\udemy\C#\Seção 13 Trabalhando com arquivos\testes\file1.txt";
            string targetPath = @"C:\Users\User\OneDrive\Área de Trabalho\udemy\C#\Seção 13 Trabalhando com arquivos\testes\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using ( StreamWriter sw = File.AppendText(targetPath)) {
                    foreach (string line in lines) {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
