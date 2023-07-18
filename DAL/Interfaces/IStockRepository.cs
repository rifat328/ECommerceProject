using ECommerceProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DAL.Interfaces
{
    public interface IStockRepository
    {
        List<Stock> GetAllStocks();
        Stock GetStockById(int stockId);
        bool AddStock(Stock stock);
        bool UpdateStock(Stock stock);
        bool DeleteStock(int stockId);
    }
}
