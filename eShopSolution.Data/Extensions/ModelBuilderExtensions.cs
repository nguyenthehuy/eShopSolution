using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public  static void Seed(this ModelBuilder modelBuilder)
        {
            //Data Seeding
            modelBuilder.Entity<AppConfig>().HasData(new AppConfig() { Key = "HomeTitle", Value = "This is a homepage of eShopSolution" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is a keyword of eShopSolution" },
                new AppConfig() { Key = "HomeDescription", Value = "This is a description of eShopSolution" });
            modelBuilder.Entity<Language>().HasData(new Language() { IsDefault = true, Id = "vi-VN", Name = "Tiếng Việt" },
                new Language() { IsDefault = false, Id = "en-US", Name = "English" });
            modelBuilder.Entity<Category>().HasData(new Category()
            {
                Id=1,
                IsShowOnHome = true,
                ParentId = null,
                SortOrder = 1,
                Status = Status.Active,
                CategoryTranslations = new List<CategoryTranslation>() { new CategoryTranslation() { 
                    Name = "Áo Nam",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nam",
                    SeoDescription="Sản phẩm áo thời trang nam",
                    SeoTitle="Sản phẩm áo thời trang nam" },
               new CategoryTranslation() { 
                   Name="men shirt",
                   LanguageId="en-US",
                   SeoAlias="men-shirt",
                   SeoTitle="Men Shirt Product",
                   SeoDescription= "Men Shirt Product"} }
            },
            new Category()
            {
                Id=2,
                IsShowOnHome = true,
                ParentId = null,
                SortOrder = 2,
                Status = Status.Active,
                CategoryTranslations = new List<CategoryTranslation>() { new CategoryTranslation() {
                    Name = "Áo Nữ",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nu",
                    SeoDescription="Sản phẩm áo thời trang nu",
                    SeoTitle="Sản phẩm áo thời trang nu" },
               new CategoryTranslation() {
                   Name="women shirt",
                   LanguageId="en-US",
                   SeoAlias="women-shirt",
                   SeoTitle="W0men Shirt Product",
                   SeoDescription= "Women Shirt Product"} }
            }
            ) ;
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id=1,
                OriginPrice = 1000000,
                Price = 20000000,
                ViewCount = 0,
                Stock = 0,
                DateCreated = DateTime.Now,

                ProductTranslations = new List<ProductTranslation>() { new ProductTranslation(){
                 Name="áo sơ mi ngắn tay trắng Việt Tiến",
                 LanguageId="vi-VN",
                 SeoAlias="ao-so-mi-soc-viet-tien",
                 SeoTitle="Áo sơ mi ngắn tay thời trang màn trắng Việt Tiến",
                 SeoDescription="Áo sơ mi ngắn tay thời trang màu trắng Việt Tiến"
             }, new ProductTranslation(){
             Name="White T-Shirt Viet Tien",
              LanguageId="en-US",
              SeoAlias="white-t-shirt-viet-tien",
              SeoTitle="White T-Shirt Viet Tien Product",
              SeoDescription="White T-Shirt Viet Tien Product"
             } },
                ProductInCategories=new List<ProductInCategory>() { new ProductInCategory() { CategoryId=1} }
            });

        }
    }
}
