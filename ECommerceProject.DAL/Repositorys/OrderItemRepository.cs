using ECommerceProject.DAL.Data;
using ECommerceProject.DAL.Entities;
using ECommerceProject.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DAL.Repositorys
{
    
    public class OrderItemRepository : IOrderItemRepository
    {
        ECommerceDataContext _context;
        public OrderItemRepository(ECommerceDataContext context)
        {
            _context=context;
        }
        public bool AddOrderItem(OrderItem orderItem)
        {
            _context.OrderItems.Add(orderItem);
            return _context.SaveChanges()>0;
        }

        public bool DeleteOrderItem(int orderItemId)
        {
            var orderItem = _context.OrderItems.FirstOrDefault(c => c.OrderItemId == orderItemId);
            if (orderItem != null)
            {
                _context.OrderItems.Remove(orderItem);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<OrderItem> GetAllOrderItems()
        {
            return _context.OrderItems.ToList();
        }

        public OrderItem GetOrderItemById(int orderItemId)
        {
            var orderItem = _context.OrderItems.FirstOrDefault(c => c.OrderItemId == orderItemId);
            return orderItem;
        }

        public bool UpdateOrderItem(OrderItem orderItem)
        {
            try
            {
                var existingOrderItem = _context.OrderItems.Find(orderItem.OrderItemId);
                if (existingOrderItem != null)
                {
                    // Update properties of the existing order item
                    existingOrderItem.ProductId = orderItem.ProductId;
                    existingOrderItem.Quantity = orderItem.Quantity;
                    existingOrderItem.Price = orderItem.Price;

                    // Save changes to the database
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                
                return false;
            }
        }
    }
}
