using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NewsPage.Data.EF
{
    internal class NewsDbContextFactory : IDesignTimeDbContextFactory<NewsPageDbContext>
    {
        public NewsPageDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("NewsDb");

            var optionsBuilder = new DbContextOptionsBuilder<NewsPageDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new NewsPageDbContext(optionsBuilder.Options);
        }
    }
}