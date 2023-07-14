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
        //Entity propertys laft for some table.,Relationship Left : for each table. 
        // then Migration 
        //then ApI 
        //Seed , and test ,
        //FrontEnd Angular 
        //Other Features 

    }
}
