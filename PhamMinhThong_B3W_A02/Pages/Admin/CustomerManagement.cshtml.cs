using BusinessObject.Models;
using CarRentingServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PhamMinhThong_B3W_A02.Pages.Admin
{
    public class CustomerManagementModel : PageModel
    {
        private readonly ICustomerService _customer;
        public CustomerManagementModel(ICustomerService customerService)
        {
            _customer = customerService;
        }
        public List<Customer> customers { get; set; }
        public void OnGet()
        {
           customers =  _customer.GetAllCustomer();
        }
    }
}
