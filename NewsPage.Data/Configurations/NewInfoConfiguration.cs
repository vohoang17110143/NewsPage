using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewsPage.Data.Entities;
using NewsPage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPage.Data.Configurations
{
    public class NewInfoConfiguration : IEntityTypeConfiguration<NewsInfo>
    {
        public void Configure(EntityTypeBuilder<NewsInfo> builder)
        {
            builder.ToTable("NewsInfo");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Content).IsRequired().HasColumnType("text");
            builder.HasOne(x => x.New).WithMany(x => x.NewsInfos).HasForeignKey(x => x.NewsId);
        }
    }
}