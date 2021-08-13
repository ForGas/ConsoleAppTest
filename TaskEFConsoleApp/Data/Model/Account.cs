using TaskEFConsoleApp.Data.Model.Base;

namespace TaskEFConsoleApp.Data.Model
{
    public class Account : BaseModel
    {
        public long ClientId { get; set; }
        public virtual BankClient BankClient { get; set; }
        public string Number { get; set; }
        public decimal Balance { get; set; }
    }
}
