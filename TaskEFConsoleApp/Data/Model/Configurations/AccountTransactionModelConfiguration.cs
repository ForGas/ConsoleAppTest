using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskEFConsoleApp.Data.Model.Configurations
{
    public class AccountTransactionModelConfiguration : IEntityTypeConfiguration<AccountTransaction>
    {
        public void Configure(EntityTypeBuilder<AccountTransaction> builder)
        {
            builder.ToTable("Account_Transactions");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.SenderClientId);
            builder.Property(x => x.SenderAccountId);
            builder.Property(x => x.RecipientClientId);
            builder.Property(x => x.RecipientAccountId);

            builder.Property(x => x.Sum).HasPrecision(29, 2);
            builder.Property(x => x.Operation);

            builder.HasIndex(x => x.Id);
        }
    }
}
