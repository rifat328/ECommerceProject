using ECommerceProject.DAL.Entities;
using ECommerceProject.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DAL.Repositorys
{
    public class OrderItemRepository : IOrderItemRepository
    {
        public bool AddOrderItem(OrderItem orderItem)
        {
            throw new NotImplementedException();
        }

        public bool DeleteOrderItem(int orderItemId)
        {
            throw new NotImplementedException();
        }

        public List<OrderItem> GetAllOrderItems()
        {
            throw new NotImplementedException();
        }

        public OrderItem GetOrderItemById(int orderItemId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateOrderItem(OrderItem orderItem)
        {
            throw new NotImplementedException();
        }
    }
}
