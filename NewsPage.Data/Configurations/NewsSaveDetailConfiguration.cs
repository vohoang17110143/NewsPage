using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewsPage.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPage.Data.Configurations
{
    public class NewsSaveDetailConfiguration : IEntityTypeConfiguration<NewsSaveDetail>
    {
        public void Configure(EntityTypeBuilder<NewsSaveDetail> builder)
        {
            builder.ToTable("NewsSaveDetail");
            builder.HasKey(x => new { x.NewsId, x.NewsSaveId });

            builder.HasOne(x => x.NewsSave).WithMany(x => x.NewsSaveDetails).HasForeignKey(x => x.NewsSaveId);
            builder.HasOne(x => x.News).WithMany(x => x.NewsSaveDetails).HasForeignKey(x => x.NewsId);
        }
    }
}