using CarRentingServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Principal;

namespace PhamMinhThong_B3W_A02.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ICustomerService _customer;
        public IndexModel()
        {
            _customer = new CustomerService();
        }
        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            
            var admin = _customer.GetAdminAccount();
            if (Email.Equals(admin.Email) && Password.Equals(admin.Password))
            {
                TempData["AdminMessage"] = "Welcome back Admin";
                return RedirectToPage("/Admin/AdminPage");
            }
            else 
            {
                var customer = _customer.Login(Email, Password);
                if (customer == null)
                {
                    ModelState.AddModelError("", "Incorrect  password");
                    return Page();
                }
                else
                {
                    HttpContext.Session.SetString("CustomerID",customer.CustomerId.ToString());
                    return RedirectToPage("/Customers/CustomerPage");
                }
            }
        }
    }
}