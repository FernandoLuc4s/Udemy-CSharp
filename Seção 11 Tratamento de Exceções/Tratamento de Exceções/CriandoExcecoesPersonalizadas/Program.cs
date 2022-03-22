using System;
using CriandoExcecoesPersonalizadas.Entities;
using CriandoExcecoesPersonalizadas.Entities.Exceptions;

namespace CriandoExcecoesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update tha reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpadateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erros in reservation: " + e.Message); // excessões do dominio
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message); // tratamento de erro de formato
            }
            catch (Exception e) // excessão generica para qualquer outro tipo de erro
            {
                Console.WriteLine("Unexpected error: "+e.Message);
            }
        }
    }
}
