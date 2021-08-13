using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskEFConsoleApp.Data.Model.Configurations
{
    public class CityModelConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("Cities");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code).HasMaxLength(30);
            builder.Property(x => x.Name).HasMaxLength(400).IsRequired();

            builder.HasIndex(x => x.Name);
        }
    }
}
