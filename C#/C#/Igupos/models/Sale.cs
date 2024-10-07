namespace Igupos.models
{
    public class Sale
    {
        public DateTime Date { get; set; }
        public int Count { get; set; }
        public float Amount { get; set; }

        public Sale() { }

        public Sale(DateTime date, int count, float amount) 
        {
            this.Date = date;
            this.Count = count;
            this.Amount = amount;
        }

    }
}
