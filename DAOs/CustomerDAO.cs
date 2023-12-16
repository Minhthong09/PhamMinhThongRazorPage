using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DAOs
{
    public class CustomerDAO
    {
        private readonly FUCarRentingManagementContext _context;
        private readonly DbSet<Customer> _dbSet;
        private static CustomerDAO instance = null;
        public CustomerDAO()
        {
            _context = new FUCarRentingManagementContext();
            _dbSet = _context.Set<Customer>();
        }
        public static CustomerDAO getInstance()
        {

            if (instance == null)
            {
                instance = new CustomerDAO();
            }
            return instance;
        }

        public Customer Login(string email, string password) 
        {
            var cus = _context.Customers.Where(c => c.Email == email && c.Password == password).FirstOrDefault();
            if (cus == null)
            {
                throw new Exception("Wrong Email Or Password");
            }
            return cus;
        }
        public List<Customer> GetAllCustomer()
        {
            return _context.Set<Customer>().ToList();
        }
        public Customer GetCustomerById(int id)
        {
            return _context.Customers.SingleOrDefault(h => h.CustomerId.Equals(id));
        }
        public void CreateCustomer(Customer customer)
        {
                _dbSet.Add(customer);
                _context.SaveChanges();
        }
        public void UpdateCustomer(Customer customer)
        {
            Customer cus = GetCustomerById(customer.CustomerId);
            if (cus != null)
            {
                _dbSet.Update(cus);
                _context.SaveChanges();
            }
        }
        public void DeleteCustomer(Customer customer)
        {
            Customer cus = GetCustomerById(customer.CustomerId);
            if (cus != null)
            {
                _dbSet.Remove(cus);
                _context.SaveChanges();
            }
        }
        public Customer GetAdminAccount() => _context.GetAccount();
    }
}

