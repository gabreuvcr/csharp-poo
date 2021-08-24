using System;
using System.Text;
using Shopping.Entities.Enums;
using System.Collections.Generic;

namespace Shopping.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items;
        public Client Client { get; set; }

        public Order(DateTime moment, OrderStatus status, Client client) 
        {
            Moment = moment;
            Status = status;
            Items = new List<OrderItem>();
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;

            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            var stringOrder = new StringBuilder();
            stringOrder.AppendLine("\nORDER SUMMARY");
            stringOrder.AppendLine($"Order Moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            stringOrder.AppendLine($"Order Status: {Status}");
            stringOrder.AppendLine($"Client: {Client}");
            stringOrder.AppendLine("Order items: ");
            foreach (OrderItem item in Items)
            {
                stringOrder.AppendLine($"{item}");
            }

            stringOrder.AppendLine($"Total price: ${Total().ToString("F2")}");

            return stringOrder.ToString();
        }
    }
}
