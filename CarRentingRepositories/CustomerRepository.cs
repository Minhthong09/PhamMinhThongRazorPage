using BusinessObject.Models;
using DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingRepositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public void CreateCustomer(Customer customer) => CustomerDAO.getInstance().CreateCustomer(customer);

        public void DeleteCustomer(Customer customer) => CustomerDAO.getInstance().DeleteCustomer(customer);

        public Customer GetAdminAccount() => CustomerDAO.getInstance().GetAdminAccount();

        public List<Customer> GetAllCustomer() => CustomerDAO.getInstance().GetAllCustomer();

        public Customer GetCustomerById(int id) => CustomerDAO.getInstance().GetCustomerById(id);

        public Customer Login(string email, string password) => CustomerDAO.getInstance().Login(email, password);
        public void UpdateCustomer(Customer customer) => CustomerDAO.getInstance().UpdateCustomer(customer);
    }
}
