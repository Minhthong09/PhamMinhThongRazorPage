using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingServices
{
    public interface IRentingService
    {
        List<RentingTransaction> GetAllRentingByCustomerID(int id);
    }
}
