using TaskEFConsoleApp.Data.Model.Base;

namespace TaskEFConsoleApp.Data.Model
{
    public class AccountTransaction : BaseModel
    {
        public long SenderClientId { get; set; }
        public long SenderAccountId { get; set; }
        public long RecipientClientId { get; set; }
        public long RecipientAccountId { get; set; }

        public decimal Sum { get; set; }
        public Operation Operation { get; set; }
    }
}
