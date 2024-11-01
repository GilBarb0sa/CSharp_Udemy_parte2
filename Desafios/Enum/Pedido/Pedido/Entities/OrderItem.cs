using System.Globalization;

namespace Pedido.Entities
{
    class OrderItem
    {
        public Product product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem()
        {
        }     

        public OrderItem(Product product, int quantity, double price) : this(product)
        {
            Quantity = quantity;
            Price = price;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}
