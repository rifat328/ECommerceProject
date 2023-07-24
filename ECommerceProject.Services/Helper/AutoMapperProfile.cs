using AutoMapper;
using ECommerceProject.DAL.Entities;
using ECommerceProject.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Service.Helper
{
    public class AutoMapperProfile :Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Cart, CartDTO>().ReverseMap();
            CreateMap<CartItem, CartItemDTO>().ReverseMap();
            CreateMap<Customer, CustomerDTO>().ReverseMap();
            CreateMap<Order, OrderDTO>().ReverseMap();
            CreateMap<OrderItem, OrderItemDTO>().ReverseMap();
            CreateMap<Review, ReviewDTO>().ReverseMap();
            CreateMap<Stock , StockDTO>().ReverseMap();
            CreateMap<User  , UserDTO>().ReverseMap();
            CreateMap<Wishlist, WishlistDTO>().ReverseMap();
            CreateMap<WishlistItem, WishlistItemDTO>().ReverseMap();
            // Add other entity-DTO mappings here
        }
    }
}
