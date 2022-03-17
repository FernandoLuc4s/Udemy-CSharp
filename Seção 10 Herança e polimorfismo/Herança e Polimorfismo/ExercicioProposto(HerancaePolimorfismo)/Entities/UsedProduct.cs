using System;

namespace ExercicioProposto_HerancaePolimorfismo_.Entities
{
    class UsedProduct : Product
    {
        public DateTime Date { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(DateTime date, string name, double price)
            :base(name, price)
        {
            Date = date;
        }

        public override string PriceTag()
        {
            return Name+" (used) $ "+Price+" (Manufacture Date: "+Date.ToString("dd/MM/yyyy")+")"; 
        }
    }
}
