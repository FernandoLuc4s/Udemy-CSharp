using System;
using System.IO;

namespace ClassePath
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\User\OneDrive\Área de Trabalho\udemy\C#\Seção 13 Trabalhando com arquivos\testes\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar); // caractere de separação
            Console.WriteLine("Path.PathSeparator: " + Path.PathSeparator); // caractere para separar as pastas
            Console.WriteLine("GetDirectoryName: "+Path.GetDirectoryName(path)); //pega o caminho da pasta e deixa de fora o nome do arquivo
            Console.WriteLine("GetFileName: " + Path.GetFileName(path)); // pega o nome do arquivo
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path)); // nome do arquivo sem extensão
            Console.WriteLine("GetExtension: " + Path.GetExtension(path)); // pega a extensão do arquivo
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path)); // pega todo o caminho do arquivo
            Console.WriteLine("GetTempPath: " + Path.GetTempPath()); // pasta temporária do sistema
        }
    }
}
