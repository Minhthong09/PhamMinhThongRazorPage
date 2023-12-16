using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingRepositories
{
    public interface IRentingRepository
    {
        List<RentingTransaction> GetAllRentingByCustomerID(int id);
    }
}
