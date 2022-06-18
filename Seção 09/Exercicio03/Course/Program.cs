using System;
using System.Globalization;
using Course.Entities;
using Course.Entities.Enum;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Birth date: ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthday);

            Console.WriteLine();
            Console.WriteLine("Enter order data: ");
            Console.Write("Status (PedidngPayment/Processing/Shipped/Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order ?: ");
            int nroOrder = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            Order order = new Order(status, client);

            for (int i = 1; i <= nroOrder; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Product quantity: ");
                int productQuantity = Int32.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);
                order.addItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMARY");
            Console.WriteLine("Order moment: " + order.Moment.ToString());
            Console.WriteLine("Order status: " + order.Status.ToString());
            Console.WriteLine("Client: " + client.ToString());
            Console.WriteLine("Order items: ");
            foreach (OrderItem item in order.OrderItems)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine($"Total price: {order.Total().ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
