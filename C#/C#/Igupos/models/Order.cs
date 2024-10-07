namespace Igupos.models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }

        public Order() { }

        public Order(int id, DateTime createdAt) 
        { 
            this.Id = id;
            this.CreatedAt = createdAt;
        }

    }
}
