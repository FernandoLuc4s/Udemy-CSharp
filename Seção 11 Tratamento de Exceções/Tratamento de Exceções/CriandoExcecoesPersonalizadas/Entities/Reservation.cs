using System;


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

        public Reservation(int roomNumber, DateTime checkin, DateTime chekout)
        {
            RoomNumber = roomNumber;
            CheckIn = checkin;
            ChekOut = chekout;
        }

        public int Duration() 
        {
            TimeSpan duration = ChekOut.Subtract(CheckIn); // pegar a diferença entre um instante e outro
            return (int)duration.TotalDays; // retorna o total de dias
        }

        public string UpadateDates(DateTime checkIn, DateTime checkOut) {

            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
                return("Error in reservation: reservations dates for update must be future dates");
            }
            if (checkOut <= checkIn)
            {
                return("Check-out date must be after check-in date");
            }
            CheckIn = checkIn;
            ChekOut = checkOut;
            return null;
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
