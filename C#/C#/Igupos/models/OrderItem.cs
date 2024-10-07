namespace Igupos.models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }

        public OrderItem() { }

        public OrderItem(int id, int productId, int quantity, float price, int orderId = 0) 
        { 
            this.Id = id;
            this.ProductId = productId;
            this.Quantity = quantity;
            this.Price = price;
            this.OrderId = orderId;
        }

    }
}
