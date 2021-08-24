namespace Shopping.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            string text = $"{Product.Name}, ${Price.ToString("F2")}, ";
            text += $"Quantity: {Quantity}, Subtotal: ${SubTotal().ToString("F2")}";
            
            return text;
        }
    }
}
