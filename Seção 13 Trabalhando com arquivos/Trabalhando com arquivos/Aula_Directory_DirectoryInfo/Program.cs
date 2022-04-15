using System;
using System.IO;

namespace Aula_Directory_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\User\OneDrive\Área de Trabalho\udemy\C#\Seção 13 Trabalhando com arquivos\testes";

            try
            {
               var folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); //"*.*" = qualquer nome de arquivo e qualquer extensão, resultado vai ser uma coleção de strings contendo as pastas
               Console.WriteLine("FOLDERS:");
               foreach (string s in folder) {
                    Console.WriteLine(s); // imprime pastas no diretorio do path
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); //"*.*" = qualquer nome de arquivo e qualquer extensão, resultado vai ser uma coleção de strings contendo as pastas
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s); // imprime arquivos no diretorio do path
                }

                // criando uma pasta

                Directory.CreateDirectory(path+ @"\newfolder");

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
