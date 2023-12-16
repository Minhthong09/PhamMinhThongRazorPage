using BusinessObject.Models;
using DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingRepositories
{
    public class RentingRepository : IRentingRepository
    {
        public List<RentingTransaction> GetAllRentingByCustomerID(int id) 
            => RentingDAO.getInstance().GetAllRentingByCustomerID(id);
    }
}
