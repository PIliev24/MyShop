﻿using MyShop.Core.Models;
using System.Data.Entity;

namespace MyShop.DataAccess.SQL
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        { }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
    }
}
