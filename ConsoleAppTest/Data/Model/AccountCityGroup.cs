using TaskEFConsoleApp.Data.Model.Base;

namespace TaskEFConsoleApp.Data.Model
{
    public class AccountCityGroup : BaseModelGroup
    {
        public decimal TotalSum { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
