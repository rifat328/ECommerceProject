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
    public class OrderRepository : IOrderRepository
    {
        ECommerceDataContext _context;
        public OrderRepository(ECommerceDataContext context)
        {
            _context = context;
        }
        public bool AddOrder(Order order)
        {
            _context.Orders.Add(order);
            return _context.SaveChanges()>0;
            
        }

        public bool DeleteOrder(int orderId)
        {
            var Order =_context.Orders.Where(c => c.OrderId == orderId).FirstOrDefault();
            if (Order != null)
            {
                _context.Orders.Remove(Order);
                return _context.SaveChanges() > 0;
            }
            else { return false; }
        }

        public List<Order> GetAllOrders()
        {
            var orders=_context.Orders.Include(c=>c.User).ToList();
            return orders;
        }

        public Order GetOrderById(int orderId)
        {
            var order = _context.Orders.FirstOrDefault(c=>c.OrderId == orderId);
            return order;
        }

        public bool UpdateOrder(Order order)
        {
            _context.Orders.Update(order);
            return _context.SaveChanges() > 0; 
        }
    }
}
