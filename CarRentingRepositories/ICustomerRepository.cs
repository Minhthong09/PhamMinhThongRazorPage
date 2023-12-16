using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingRepositories
{
    public interface ICustomerRepository
    {
        Customer Login(string email, string password);
        Customer GetCustomerById(int id);
        List<Customer> GetAllCustomer();
        void CreateCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
        Customer GetAdminAccount();
    }
}
