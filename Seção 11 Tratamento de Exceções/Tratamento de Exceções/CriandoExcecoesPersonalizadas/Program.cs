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

                DateTime now = DateTime.Now;

                if (checkIn < now || checkOut < now)
                {
                    Console.WriteLine("Error in reservation: reservations dates for update must be future dates");
                }
                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("Erros in reservation: Check-out date must be after check-in date");
                }
                else 
                {
                    reservation.UpadateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation: "+reservation);
                }
            }
            
        }
    }
}
