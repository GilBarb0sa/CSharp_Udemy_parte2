using Pedido.Entities.Enums;
using System;
using System.Collections.Generic;

namespace Pedido.Entities
{
    class Order
    {        
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(Client client, DateTime moment, OrderStatus status)
        {
            Client = client;
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            OrderItems.Remove(orderItem);
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem orderItem in OrderItems)
            {
                total += orderItem.SubTotal();
            }
            return total;
        }
    }
}
