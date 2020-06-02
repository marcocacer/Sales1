﻿
namespace Sales1.Domain.Models
{
    using System.Data.Entity;
    using Sales1.Common.Models;

    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
