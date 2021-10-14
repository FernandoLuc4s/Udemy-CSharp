using System;
using Enumeração.Entities;
using Enumeração.Entities.Enums;

namespace Enumeração
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment // tipo do status
            };
            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); // convertendo string para enum 
            Console.WriteLine(os);
            Console.WriteLine(txt); // convertendo enum para string
        }
    }
}
