using ECommerceProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DAL.Interfaces
{
    public interface IOrderRepository
    {
        List<Order> GetAllOrders();
        Order GetOrderById(int orderId);
        bool AddOrder(Order order);
        bool UpdateOrder(Order order);
        bool DeleteOrder(int orderId);
    }
}
