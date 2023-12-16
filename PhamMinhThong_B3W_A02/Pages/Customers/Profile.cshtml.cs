using CarRentingServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Principal;
using BusinessObject.Models;

namespace PhamMinhThong_B3W_A02.Pages.Customers
{
    public class ProfileModel : PageModel
    {
        private readonly ICustomerService _customerService;
        public ProfileModel (ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [BindProperty]
        public Customer Customer { get; set; } = default!;
        public void OnGet()
        {
            int id = Convert.ToInt32(HttpContext.Session.GetString("CustomerID")) ;
            Customer = _customerService.GetCustomerById(id);
            
        }
        public IActionResult OnPost()
        { 
            int id = Convert.ToInt32(HttpContext.Session.GetString("CustomerID"));
            var cus = _customerService.GetCustomerById(id);
            if (cus!= null)
            {
                cus.CustomerName = Customer.CustomerName;
                cus.Telephone = Customer.Telephone;
                cus.CustomerBirthday = Customer.CustomerBirthday;

                _customerService.UpdateCustomer(cus);
                return RedirectToPage();
            }
            else
            {
                return RedirectToPage();
            }
        }
    }
}
