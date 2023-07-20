using ECommerceProject.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DAL.Data
{
    public class ECommerceDataContext:DbContext
    {
        public ECommerceDataContext(DbContextOptions<ECommerceDataContext> options):base(options) 
        {

            
        }
        public DbSet<Cart>Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<WishlistItem> WishlistItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "Crocex Snail Cream", Description = "For Face Cream , Female Product",
                    Price = 800, CategoryId = 1, Company = "Crocex",
                    ImageURL = @"F:\Projects\C#\ECommerceProject\DAL\Resources\ProductImage\advanced-snail-92-all-in-one-cream-cosrx-official-1_720x.webp",
                    CreatedDate = DateTime.Now, IsDeleted=false },
                new Product
                {
                    ProductId = 2,
                    Name = "Crocex Snail Mucas",
                    Description = "For Face Cream , Female Product",
                    Price = 850,
                    CategoryId = 1,
                    Company = "Crocex",
                    ImageURL = @"F:\Projects\C#\ECommerceProject\DAL\Resources\ProductImage\advanced-snail-92-all-in-one-cream-cosrx-official-1_720x.webp",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                }, 
                new Product
                {
                    ProductId = 3,
                    Name = "The Vitamin C 23 Serum",
                    Description = "For Face Cream , Female Product",
                    Price = 890,
                    CategoryId = 1,
                    Company = "Crocex",
                    ImageURL = @"F:\Projects\C#\ECommerceProject\DAL\Resources\ProductImage\the-vitamin-c-23-serum-cosrx-official-1_720x.webp",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                }
                
                ) ;
            //Category entry seed.
            modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, Name = "Beauty Product", Description = "Category 1 Beauty Cosmetics", IsDeleted = false },
            new Category { CategoryId = 2, Name = "Baby Product", Description = "Category 2 Baby derated product", IsDeleted = false },
            new Category { CategoryId = 3, Name = "Grochary", Description = " Day to day product", IsDeleted = false }
                );


        }

        // then Migration 
        //then ApI 
        //Seed , and test ,
        //FrontEnd Angular 
        //Other Features 

    }
}
