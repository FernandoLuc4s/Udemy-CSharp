using System;

namespace FuncoesInteressantesParaString
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG   ";
            string s1 = original.ToUpper(); // converte toda a sting pra maiúsculo
            string s2 = original.ToLower(); // converte toda a sting pra minúsculo
            string s3 = original.Trim(); // apaga os espaços em branco no inicio e no fim

            int n1 = original.IndexOf("bc"); // pega a posição da string que você determina;
            int n2 = original.LastIndexOf("bc"); // pega a ultima posição que você determina;

            string s4 = original.Substring(3); // corta a string a partir da posição indicada
            string s5 = original.Substring(3, 5); // corta a string a partir da posição indicada e retorna o número de caracteres determinado

            string s6 = original.Replace('a','x'); // pode pegar um caractere ou string e substituir por outro
            string s7 = original.Replace("abc", "xy"); // pode pegar um caractere ou string e substituir por outro

            bool b1 = string.IsNullOrEmpty(original); // testa se o conteúdo da variável é nulo ou  vazio
            bool b2 = string.IsNullOrWhiteSpace(original);  // testa se o conteúdo da variável é nulo ou se tem espeço vazio

            Console.WriteLine("Original: -"+original+"-");
            Console.WriteLine("ToUpper: -"+s1+"-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -"+s3+"-");
            Console.WriteLine("IndexOf('bc'): -"+n1 + "-");
            Console.WriteLine("LastIndexOf('bc'): -"+n2 + "-");
            Console.WriteLine("Substring(3): -"+s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a','x'): -"+ s6 + "-");
            Console.WriteLine("Replace('abc','xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: "+b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);


        }
    }
}
