namespace ProductOrderSystem
{
    public class Product
    {
        private string name;
        private int productId;
        private double price;
        private int quantity;

        public Product(string name, int productId, double price, int quantity)
        {
            this.name = name;
            this.productId = productId;
            this.price = price;
            this.quantity = quantity;
        }

        public string Name => name;
        public int ProductId => productId;

        public double TotalCost()
        {
            return price * quantity;
        }
    }
}