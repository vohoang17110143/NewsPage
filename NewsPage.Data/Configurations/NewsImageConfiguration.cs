using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewsPage.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPage.Data.Configurations
{
    public class NewsImageConfiguration : IEntityTypeConfiguration<NewsImage>
    {
        public void Configure(EntityTypeBuilder<NewsImage> builder)
        {
            builder.ToTable("NewsImages");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.ImagePath).HasMaxLength(200).IsRequired(true);
            builder.Property(x => x.Caption).HasMaxLength(200);

            builder.HasOne(x => x.New).WithMany(x => x.NewsImages).HasForeignKey(x => x.NewsId);
        }
    }
}