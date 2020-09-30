using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewsPage.Data.Entities;
using NewsPage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPage.Data.Configurations
{
    public class CategoryInfoConfiguration : IEntityTypeConfiguration<CategoryInfo>
    {
        public void Configure(EntityTypeBuilder<CategoryInfo> builder)
        {
            builder.ToTable("CategoryTranslations");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            builder.HasOne(x => x.Category).WithMany(x => x.CategoryInfos).HasForeignKey(x => x.CategoryId);
        }
    }
}