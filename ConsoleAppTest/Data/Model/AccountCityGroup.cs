using ConsoleAppTest.Data.Model.Base;

namespace ConsoleAppTest.Data.Model
{
    public class AccountCityGroup : BaseModelGroup
    {
        public decimal TotalSum { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
