using TaskEFConsoleApp.Data.Model.Base;
using System;

namespace TaskEFConsoleApp.Data.Model
{
    public class BankClient : BaseModel
    {
        public long CityId { get; set; }
        public long CountryId { get; set; }
        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual Account Account { get; set; }

        public string Address { get; set; }
        public string FullName { get; set; }
        public string Iin { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
