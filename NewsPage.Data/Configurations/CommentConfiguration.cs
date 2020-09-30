using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewsPage.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPage.Data.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Content).IsRequired().HasMaxLength(500);

            builder.HasOne(x => x.AppUser).WithMany(x => x.Comments).HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.New).WithMany(x => x.Comments).HasForeignKey(x => x.NewsId);
        }
    }
}