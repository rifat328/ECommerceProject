using ECommerceProject.DAL.Data;
using ECommerceProject.DAL.Entities;
using ECommerceProject.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DAL.Repositorys
{
    public class StockRepository : IStockRepository
    {
        ECommerceDataContext _context;
        public StockRepository(ECommerceDataContext context)
        {
            _context = context;
        }
        public bool AddStock(Stock stock)
        {
            _context.Stocks.Add(stock);
            return _context.SaveChanges() > 0;
        }

        public bool DeleteStock(int stockId)
        {
            var stock = _context.Stocks.FirstOrDefault(s => s.StockID == stockId);
            if (stock != null)
            {
                _context.Stocks.Remove(stock);
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        public List<Stock> GetAllStocks()
        {
            return _context.Stocks.ToList();
        }

        public Stock GetStockById(int stockId)
        {
            return _context.Stocks.FirstOrDefault(s => s.StockID == stockId);
        }

        public bool UpdateStock(Stock stock)
        {
            _context.Stocks.Update(stock);
            return _context.SaveChanges() > 0;
        }
    }
}
