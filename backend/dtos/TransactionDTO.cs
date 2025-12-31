using Models;

namespace DTOs
{
    public class TransactionDTO
    {
        public int Id { get; set; }

        public DateTime? Date { get; set; }
        public string? Description { get; set; }
        public decimal? Amount { get; set; }

        public int AccountID { get; set; }
        public int CategoryID { get; set; }

        public TransactionDTO() { }
        public TransactionDTO(Transaction transaction) =>
            (Id, Date, Description, Amount, AccountID, CategoryID) = 
            (transaction.Id, 
            transaction.Date, 
            transaction.Description, 
            transaction.Amount, 
            transaction.AccountID, 
            transaction.CategoryID);
    }   
}