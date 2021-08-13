using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskEFConsoleApp.Data.Model.Configurations
{
    public class CountryModelConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Countries");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code).HasMaxLength(30);
            builder.Property(x => x.Name).HasMaxLength(400).IsRequired();

            builder.HasIndex(x => x.Name);
        }
    }
}
