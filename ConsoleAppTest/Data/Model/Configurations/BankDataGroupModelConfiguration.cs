using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest.Data.Model.Configurations
{
    class BankDataGroupModelConfiguration : IEntityTypeConfiguration<BankDataGroup>
    {
        public void Configure(EntityTypeBuilder<BankDataGroup> builder)
        {
            builder.HasNoKey();
            builder.ToView("View_BankData");
        }
    }
}
