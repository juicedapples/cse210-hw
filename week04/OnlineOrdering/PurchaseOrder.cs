using System;
using System.Collections.Generic;

namespace ProductOrderSystem
{
    public class PurchaseOrder
    {
        private int orderId;
        private Customer customer;
        private List<Product> orderList;

        public PurchaseOrder(int orderId, Customer customer, List<Product> orderList)
        {
            this.orderId = orderId;
            this.customer = customer;
            this.orderList = orderList;
        }

        public int OrderId => orderId;
        public Customer Customer => customer;
        public List<Product> OrderList => orderList;

        public double TotalPrice()
        {
            double totalCost = 0;

            foreach (var product in orderList)
            {
                totalCost += product.TotalCost();
            }

            double shippingCost = customer.LivesInUSA() ? 5.00 : 35.00;
            totalCost += shippingCost;

            return totalCost;
        }

        public string PackingLabel()
        {
            string label = "Packing Label:\n";

            foreach (var product in orderList)
            {
                label += $"{product.Name} (ID: {product.ProductId})\n";
            }

            return label;
        }

        public string ShippingLabel()
        {
            string label = "Shipping Label:\n";
            label += $"{customer.Name}\n";
            label += customer.CustomerAddress.GetFullAddress();

            return label;
        }
    }
}