using Photerva.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Photerva.Lib.DataAccess
{
    public class PhotervaRepository : IPhotervaRepository
    {
        private readonly ApplicationDbContext _context;

        public PhotervaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Customer> GetCustomers(string ownerID)
        {
            try
            {
                return _context.Customer
                    .Where(w => w.OwnerID == ownerID).ToList();
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
