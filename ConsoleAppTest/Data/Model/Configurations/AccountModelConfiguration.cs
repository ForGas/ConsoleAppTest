using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskEFConsoleApp.Data.Model.Configurations
{
    public class AccountModelConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Accounts");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Balance).HasPrecision(29, 2);
            builder.Property(x => x.Number).HasMaxLength(15).IsRequired();

            builder.HasIndex(x => x.Number);
        }
    }
}
