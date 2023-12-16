using BusinessObject.Models;
using CarRentingServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PhamMinhThong_B3W_A02.Pages
{
    public class RegisterModel : PageModel
    {
		private readonly ICustomerService _customer;
		public RegisterModel()
		{
			_customer = new CustomerService();
		}
		[BindProperty]
		public string Name { get; set; }

		[BindProperty]
		public string Phone { get; set; }

		[BindProperty]
		public string Email { get; set; }

		[BindProperty]
		public DateTime Birthday { get; set; }

		[BindProperty]
		public string Password { get; set; }
		public void OnGet()
        {
        }
		public IActionResult OnPost()
		{
			var customer = new Customer()
			{
				CustomerName = Name,
				Telephone = Phone,
				Email = Email,
				CustomerBirthday = Birthday,
				Password = Password,
				CustomerStatus = 1
			};

			_customer.CreateCustomer(customer);
			return RedirectToPage("/Index");
		}
    }
}
