using System;
using System.IO;

namespace FileStreamEStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\User\OneDrive\Área de Trabalho\udemy\C#\Seção 13 Trabalhando com arquivos\testes\file1.txt";
          
            StreamReader sr = null;
            try
            {


                sr = File.OpenText(path); // usando o filestram de uma forma implicita
                while (!sr.EndOfStream) { // enquanto não chegar no fim da stream
                    string line = sr.ReadLine(); // ler uma linha do arquivo

                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
            finally {
                if (sr != null) sr.Close();
              
            }
        }
    }
}
