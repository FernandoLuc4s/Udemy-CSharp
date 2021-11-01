using System;

namespace ExercFixVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int numQuartos = 9;
            Estudante[] quartos = new Estudante[numQuartos];
            Console.WriteLine("Quantos quartos serão alugados ? ");
            int numEstudantes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numEstudantes; i++)
            {
                Console.WriteLine("Aluguel #"+i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int numQuarto = int.Parse(Console.ReadLine());
                quartos[numQuarto] = new Estudante { Nome = nome, Email = email };
            }
            Console.WriteLine("Quartos Ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (quartos[i]!=null)
                {
                   Console.WriteLine(i +": "+quartos[i].Nome+", "+ quartos[i].Email);
                }
               // Console.WriteLine("Quartos Ocupados: " + quartos[i].Quarto + ": " + quartos[i].Nome + ", " + quartos[i].Email);
            }
        }
    }
}
