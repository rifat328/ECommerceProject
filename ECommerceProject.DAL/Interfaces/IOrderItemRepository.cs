using ECommerceProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DAL.Interfaces
{
    public interface IOrderItemRepository
    {
        List<OrderItem> GetAllOrderItems();
        OrderItem GetOrderItemById(int orderItemId);
        bool AddOrderItem(OrderItem orderItem);
        bool UpdateOrderItem(OrderItem orderItem);
        bool DeleteOrderItem(int orderItemId);
    }
}
