using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewsPage.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPage.Data.Configurations
{
    public class NewsSaveConfiguration : IEntityTypeConfiguration<NewsSave>
    {
        public void Configure(EntityTypeBuilder<NewsSave> builder)
        {
            builder.ToTable("NewsSave");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasOne(x => x.AppUser).WithMany(x => x.NewsSaves).HasForeignKey(x => x.UserId);
        }
    }
}