using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.EF
{
    public class EShopDbContext : DbContext
    {
        public EShopDbContext( DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products;
        public DbSet<AppConfig> AppConfigs;
        public DbSet<Cart> Carts;
        public DbSet<Category> Categories;
        public DbSet<CategoryTranslation> CategoryTranslations;
        public DbSet<Contact> Contacts;
        public DbSet<Language> Languages;
        public DbSet<Order> Orders;
        public DbSet<OrderDetail> OrderDetails;
        public DbSet<ProductInCategory>  ProductInCategories;
        public DbSet<ProductTransaction> ProductTransactions;
        public DbSet<Promotion> Promotions;
        public DbSet<Transaction> Transactions;

    }
}
