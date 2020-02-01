using eShopSolution.Data.Configurations;
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfigration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new ProductInCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new PromotionsConfiguration());
            modelBuilder.ApplyConfiguration(new TransationConfiguration());
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
        public DbSet<ProductTranslation> ProductTranslations;
        public DbSet<Promotion> Promotions;
        public DbSet<Transaction> Transactions;

    }
}
