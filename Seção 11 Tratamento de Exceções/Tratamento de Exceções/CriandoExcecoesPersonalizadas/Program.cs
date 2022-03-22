using System;
using CriandoExcecoesPersonalizadas.Entities;

namespace CriandoExcecoesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            // forma errada de verificação por conta da delegação e também dos if's e else's

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Erros in reservation: Check-out date must be after check-in date");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: "+reservation);
                Console.WriteLine();
                Console.WriteLine("Enter data to update tha reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                string error = reservation.UpadateDates(checkIn, checkOut);
                if (error != null)
                {
                    Console.WriteLine("Error in reservation: "+error);
                }
                else
                {
                    Console.WriteLine("Reservation: " + reservation);
                }
            }
            
        }
    }
}
