using Photerva.Lib.DataAccess;
using Photerva.Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Photerva.Lib.Logic
{
    public class PhotervaService : IPhotervaService
    {
        private readonly IPhotervaRepository _repo;

        public PhotervaService(IPhotervaRepository repo)
        {
            _repo = repo;
        }

        public List<Customer> GetCustomers(string ownerID)
        {
            return _repo.GetCustomers(ownerID);
        }

        public List<Session> GetSessions(string ownerID, DateTime? startDate, DateTime? endDate)
        {
            return _repo.GetSessions(ownerID, startDate, endDate);
        }

    }
}
