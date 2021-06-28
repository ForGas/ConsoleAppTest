using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleAppTest.Data.Model.Configurations
{
    class AccountCityGroupModelConfiguration : IEntityTypeConfiguration<AccountCityGroup>
    {
        public void Configure(EntityTypeBuilder<AccountCityGroup> builder)
        {
            builder.HasNoKey();
            builder.ToView("View_BalanceByCity");
        }
    }
}
