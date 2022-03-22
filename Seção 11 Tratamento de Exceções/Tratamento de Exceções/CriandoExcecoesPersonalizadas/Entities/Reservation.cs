using System;
using CriandoExcecoesPersonalizadas.Entities.Exceptions;


namespace CriandoExcecoesPersonalizadas.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime ChekOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime chekOut)
        {
            if (chekOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            ChekOut = chekOut;
        }

        public int Duration() 
        {
            TimeSpan duration = ChekOut.Subtract(CheckIn); // pegar a diferença entre um instante e outro
            return (int)duration.TotalDays; // retorna o total de dias
        }

        public void UpadateDates(DateTime checkIn, DateTime checkOut) {

            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Reservation dates for update must be future dates"); // thorw = lançar a frase de exception
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }
            CheckIn = checkIn;
            ChekOut = checkOut;
        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + ChekOut.ToString("dd/MM/yyyy")
                +", "
                +Duration()
                +" nights";

        }
    }
}
