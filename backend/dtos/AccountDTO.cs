
using Models;

namespace DTOs
{
    public class AccountDTO
    {
        public int Id { get; set; }
        public string? CurrencyType { get; set; }
        public string? AccountName { get; set; }

        public AccountDTO() { }
        public AccountDTO(Account account) => 
            (Id, CurrencyType, AccountName) = (account.Id, account.CurrencyType, account.AccountName);
    }   
}