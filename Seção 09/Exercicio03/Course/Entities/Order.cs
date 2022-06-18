using System;
using System.Globalization;
using System.Collections.Generic;
using Course.Entities.Enum;

namespace Course.Entities
{
    class Order
    {

        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        DateTime _moment;
        public DateTime Moment { get { return _moment; } private set { } }

        public Order()
        {

        }

        public Order(OrderStatus status, Client client)
        {
            this._moment = DateTime.Now;
            this.Status = status;
            this.Client = client;
        }


        public void addItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }

        public void removeItem (OrderItem orderItem)
        {
            OrderItems.Remove(orderItem);
        }

        public double Total ()
        {
            double total = 0.0;

            foreach (OrderItem item in OrderItems)
            {
                total += item.SubTotal();
            }

            return total;
        }
    }
}
