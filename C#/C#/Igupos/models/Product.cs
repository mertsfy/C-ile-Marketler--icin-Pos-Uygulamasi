namespace Igupos.models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public int CategoryId { get; set; }


        public Product() { }

        public Product(int id, string name, int quantity, float price, int categoryId) 
        { 
            this.Id = id;
            this.Name = name;
            this.Quantity = quantity;
            this.Price = price;
            this.CategoryId = categoryId;
        }

    }
}
