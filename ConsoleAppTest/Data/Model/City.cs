using ConsoleAppTest.Data.Model.Base;

namespace ConsoleAppTest.Data.Model
{
    public class City : BaseModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public virtual BankClient BankClient { get; set; }
    }
}
