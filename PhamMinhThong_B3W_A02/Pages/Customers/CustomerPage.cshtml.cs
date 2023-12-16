using BusinessObject.Models;
using CarRentingServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PhamMinhThong_B3W_A02.Pages.Customers
{
    public class CustomerPageModel : PageModel
    {
        private readonly IRentingService _rentingService;
        private readonly ICustomerService _customerService;
        public CustomerPageModel(IRentingService rentingService, ICustomerService customer  )
        {
            _rentingService = rentingService;
            _customerService = customer;
        }
        [BindProperty]
        public List<RentingTransaction> Renting { get; set; } = default!;
        public IActionResult OnGet()
        {
            int id = Convert.ToInt32(HttpContext.Session.GetString("CustomerID"));
            var cus = _customerService.GetCustomerById(id);
            Renting = _rentingService.GetAllRentingByCustomerID(cus.CustomerId);
            return Page();
        }
    }
}
