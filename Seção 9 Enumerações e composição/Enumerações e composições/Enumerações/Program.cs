using Enumerações.Entities;
using Enumerações.Entities.Enums;
using System;

namespace Enumerações
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt); // convertendo um tipo enumerado para um tipo string

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); // convertendo uma string para um tipo enum  

            Console.WriteLine(os);
        }
    }
}
