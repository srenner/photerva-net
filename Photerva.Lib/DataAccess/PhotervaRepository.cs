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

        public List<Session> GetSessions(string ownerID, DateTime? startDate, DateTime? endDate)
        {
            try
            {
                return _context.Session
                    .Where(w => w.OwnerID == ownerID)
                    .ToList();
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
