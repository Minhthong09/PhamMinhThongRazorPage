using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOs
{
    public class RentingDAO
    {
        private readonly FUCarRentingManagementContext _context;
        private readonly DbSet<RentingTransaction> _dbSet;
        private static RentingDAO instance = null;
        public RentingDAO()
        {
            _context = new FUCarRentingManagementContext();
            _dbSet = _context.Set<RentingTransaction>();
        }
        public static RentingDAO getInstance()
        {

            if (instance == null)
            {
                instance = new RentingDAO();
            }
            return instance;
        }
        public List<RentingTransaction> GetAllRentingByCustomerID(int id)
        {
            return _dbSet.Where(s => s.CustomerId == id).ToList();
        }
    }
}
