namespace Models
{
    public class Transaction
    {
        public int Id { get; set; }

        public DateTime? Date { get; set; }
        public string? Description { get; set; }
        public decimal? Amount { get; set; }

        public int AccountID { get; set; }
        public int CategoryID { get; set; }

        public Account Account { get; set; } = null!;
        public Category Category { get; set; } = null!;
}
}