using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NewsPage.Data.Entities;
using NewsPage.Data.Enum;
using NewsPage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPage.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
           new AppConfig() { Key = "HomeTitle", Value = "This is home page of NewsPage" },
           new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of NewsPage" },
           new AppConfig() { Key = "HomeDescription", Value = "This is description of NewsPage" }
           );

            modelBuilder.Entity<Category>().HasData(
               new Category()
               {
                   Id = 1,
                   Name = "Xã hội",
                   IsShowOnHome = true,
                   ParentId = null,
                   SortOrder = 1,
                   Status = Status.Active,
               },
                new Category()
                {
                    Id = 2,
                    Name = "Pháp luật",
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active
                },
                new Category()
                {
                    Id = 3,
                    Name = "Thế giới",
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 3,
                    Status = Status.Active
                },
                new Category()
                {
                    Id = 4,
                    Name = "Kinh doanh",
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 4,
                    Status = Status.Active
                },
                new Category()
                {
                    Id = 5,
                    Name = "Công nghệ",
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 5,
                    Status = Status.Active
                },
                new Category()
                {
                    Id = 6,
                    Name = "Sức khỏe",
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 6,
                    Status = Status.Active
                }
                );

            modelBuilder.Entity<CategoryInfo>().HasData(
                   new CategoryInfo() { Id = 1, CategoryId = 1, Name = "Chính trị" },
                   new CategoryInfo() { Id = 2, CategoryId = 1, Name = "Giao thông" },
                   new CategoryInfo() { Id = 3, CategoryId = 1, Name = "Đô thị" },
                   new CategoryInfo() { Id = 4, CategoryId = 2, Name = "Pháp đình" },
                   new CategoryInfo() { Id = 5, CategoryId = 2, Name = "Vụ án" }
                 );

            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "vohoang17110143@gmail.com",
                PhoneNumber = "09087123412",
                NormalizedEmail = "vohoang17110143@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Hoang",
                LastName = "Nguyen Vo",
                Dob = new DateTime(2020, 01, 31)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
}