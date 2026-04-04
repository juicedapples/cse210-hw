using System;
using System.Collections.Generic;

namespace ProductOrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Address address1 = new Address("1234 Main Street", "Orem", "UT", "USA");
                Address address2 = new Address("1010 Willow Creek Drive", "Toronto", "ON", "Canada");

                Customer customer1 = new Customer("Camille Stephens", address1);
                Customer customer2 = new Customer("Heather Harrison", address2);

                Product product1 = new Product("Phone", 001, 599.99, 1);
                Product product2 = new Product("Bluetooth speaker", 002, 39.99, 2);
                Product product3 = new Product("Mouse and Keyboard Combo", 003, 19.99, 1);

                List<Product> orderList1 = new List<Product> { product1, product2 };
                PurchaseOrder order1 = new PurchaseOrder(1, customer1, orderList1);

                List<Product> orderList2 = new List<Product> { product2, product3 };
                PurchaseOrder order2 = new PurchaseOrder(2, customer2, orderList2);

                DisplayOrderDetails(order1);


                DisplayOrderDetails(order2);
            }
            catch (Exception ex)
            {
                // Creative add-on error handeling
                ErrorHandling.LogException(ex);
                ErrorHandling.DisplayGenericError();
            }
        }

        static void DisplayOrderDetails(PurchaseOrder order)
        {
            Console.WriteLine($"Order ID: {order.OrderId}");
            Console.WriteLine(order.PackingLabel());
            Console.WriteLine(order.ShippingLabel());
            Console.WriteLine($"Total Price: ${order.TotalPrice():0.00}\n");
        }
    }
}