using System;
using Microsoft.EntityFrameworkCore;

namespace SampleMVCApps
{
    public class OrderingContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public string DbPath { get; private set; }

        public OrderingContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}ordering.db";
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}