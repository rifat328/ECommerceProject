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
    public class CustomerRepository : ICustomerRepository
    {
        ECommerceDataContext _context;
        public CustomerRepository(ECommerceDataContext DbContext)
        {
            _context = DbContext;
        }

        public bool AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            return _context.SaveChanges() > 0;
        }

        public bool DeleteCustomer(int customerId)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.CustomerId == customerId);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                return _context.SaveChanges() > 0;
            }
            else return false;
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.Where(c=>c.IsDeleted==false).ToList();
        }

        public Customer GetCustomerById(int customerId)
        {
           var customer = _context.Customers.Where(c => c.CustomerId == c.CustomerId).FirstOrDefault();
            return customer;
        }

        public bool UpdateCustomer(Customer customer)
        {
            _context.Customers.Update(customer);
            return _context.SaveChanges() > 0;
        }
    }
    
}
