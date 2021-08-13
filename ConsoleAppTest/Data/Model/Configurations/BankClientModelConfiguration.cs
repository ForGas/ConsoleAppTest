using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskEFConsoleApp.Data.Model.Configurations
{
    public class BankClientModelConfiguration : IEntityTypeConfiguration<BankClient>
    {
        public void Configure(EntityTypeBuilder<BankClient> builder)
        {
            builder.ToTable("Bank_Clients");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CityId);
            builder.Property(x => x.CountryId);
            builder.Property(x => x.DateOfBirth).IsRequired();
            builder.Property(x => x.Address).HasMaxLength(300).IsRequired();
            builder.Property(x => x.FullName).HasMaxLength(400).IsRequired();
            builder.Property(x => x.Iin).HasMaxLength(12).IsFixedLength().IsRequired();

            builder.HasIndex(x => x.FullName);
            builder.HasIndex(x => x.Iin).IsUnique();

            builder.HasOne(x => x.City)
                .WithOne(c => c.BankClient)
                .HasForeignKey<BankClient>(x => x.CityId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Country)
               .WithOne(c => c.BankClient)
               .HasForeignKey<BankClient>(x => x.CountryId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Account)
               .WithOne(a => a.BankClient)
               .HasForeignKey<Account>(a => a.ClientId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
