using System;
using TaskEFConsoleApp.Data.Model.Base;

namespace TaskEFConsoleApp.Data.Model
{
    public class BankDataGroup : BaseModelGroup
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Iin { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string City { get; set; }
        public string CityCode { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Number { get; set; }
        public decimal Balance { get; set; }
    }
}
