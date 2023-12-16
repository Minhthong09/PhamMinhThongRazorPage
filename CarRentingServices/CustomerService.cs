using BusinessObject.Models;
using CarRentingRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingServices
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _cusRepo;

        public CustomerService() 
        { 
            _cusRepo= new CustomerRepository();
        }
        public void CreateCustomer(Customer customer) => _cusRepo.CreateCustomer(customer);    

        public void DeleteCustomer(Customer customer) => _cusRepo.DeleteCustomer(customer);

        public Customer GetAdminAccount()
        {
            return _cusRepo.GetAdminAccount();
        }

        public List<Customer> GetAllCustomer()
        {
            return _cusRepo.GetAllCustomer();
        }

        public Customer GetCustomerById(int id)
        {
            return _cusRepo.GetCustomerById(id);
        }

        public Customer Login(string email, string password)
        {
            return _cusRepo.Login(email, password);
        }

        public void UpdateCustomer(Customer customer) => _cusRepo.UpdateCustomer(customer);
    }
}
