using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingServices
{
    public interface ICustomerService
    {
        Customer Login(string email, string password);
        Customer GetCustomerById(int id);
        void CreateCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
        Customer GetAdminAccount();
        List<Customer> GetAllCustomer();
    }
}
