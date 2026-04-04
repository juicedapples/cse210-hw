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
                LocationDetails address1 = new LocationDetails("1234 Main Street", "Orem", "UT", "USA");
                LocationDetails address2 = new LocationDetails("1010 Willow Creek", "Toronto", "ON", "Canada");

                Client client1 = new Client("Camille Stephens", address1);
                Client client2 = new Client("Kyle Mortinson", address2);

                ProductInfo product1 = new ProductInfo("Laptop", 101, 999.99, 1);
                ProductInfo product2 = new ProductInfo("Headset", 102, 49.99, 2);
                ProductInfo product3 = new ProductInfo("Keyboard", 103, 79.99, 1);

                List<ProductInfo> orderList1 = new List<ProductInfo> { product1, product2 };
                PurchaseOrder order1 = new PurchaseOrder(1, client1, orderList1);

                List<ProductInfo> orderList2 = new List<ProductInfo> { product2, product3 };
                PurchaseOrder order2 = new PurchaseOrder(2, client2, orderList2);

                DisplayOrderDetails(order1);

                DisplayOrderDetails(order2);
            }
            catch (Exception ex)
            {
                // Creative add on Handle errors
                ErrorHandling.LogException(ex);
                ErrorHandling.DisplayGenericError();
            }
        }

        static void DisplayOrderDetails(PurchaseOrder order)
        {
            Console.WriteLine($"Order Number: {order.OrderNumber}");
            Console.WriteLine(order.GeneratePackingLabel());
            Console.WriteLine(order.GenerateShippingLabel());
            Console.WriteLine($"Total Price: ${order.ComputeTotalCost():0.00}\n");
        }
    }
}