using BusinessObject.Models;
using CarRentingRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingServices
{
    public class RentingService : IRentingService
    {
        private readonly IRentingRepository _renting;
        public RentingService()
        {
            _renting = new RentingRepository();
        }
        public List<RentingTransaction> GetAllRentingByCustomerID(int id)
        {
            return _renting.GetAllRentingByCustomerID(id);
        }
    }
}
