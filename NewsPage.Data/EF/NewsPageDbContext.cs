using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NewsPage.Data.Configurations;
using NewsPage.Data.Entities;
using NewsPage.Data.Extensions;
using NewsPage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPage.Data.EF
{
    public class NewsPageDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public NewsPageDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());

            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryInfoConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new NewConfiguration());
            modelBuilder.ApplyConfiguration(new NewsImageConfiguration());
            modelBuilder.ApplyConfiguration(new NewsInCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new NewsSaveConfiguration());
            modelBuilder.ApplyConfiguration(new NewsSaveDetailConfiguration());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

            //seeding data
            modelBuilder.Seed();
        }

        public DbSet<New> News { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryInfo> CategoryInfos { get; set; }
        public DbSet<NewsInCategory> NewsInCategories { get; set; }
        public DbSet<AppConfig> AppConfigs { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public DbSet<NewsImage> NewsImages { get; set; }

        public DbSet<NewsSave> NewsSaves { get; set; }
        public DbSet<NewsSaveDetail> NewsSaveDetails { get; set; }
    }
}