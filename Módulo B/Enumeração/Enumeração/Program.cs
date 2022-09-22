using Enumeração.Entities;
using Enumeração.Entities.Enums;
using System;

namespace Enumeração
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1200,
                Moment = DateTime.Now,
                Status = OrderStatus.PedingPayment
            };

            Console.WriteLine($"Seu pedido {order}");

            string message = OrderStatus.PedingPayment.ToString();

            OrderStatus now = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine($"Aviso {message}");
            Console.WriteLine($"Situação {now}");
        }
    }
}
