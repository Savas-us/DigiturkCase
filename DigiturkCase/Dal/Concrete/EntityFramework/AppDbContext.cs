using DigiturkCase.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiturkCase.Dal.Concrate.EntityFramework
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                    optionsBuilder.UseSqlServer(@"Server=SAVAS-US\SQLEXPRESS;database=DigiturkCaseDB;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }
        public DbSet<Article> Articles { get; set; }
    }
}
