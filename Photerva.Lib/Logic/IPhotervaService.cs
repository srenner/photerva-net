using Photerva.Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Photerva.Lib.Logic
{
    public interface IPhotervaService
    {
        List<Customer> GetCustomers(string ownerID);
        List<Session> GetSessions(string ownerID, DateTime? startDate, DateTime? endDate);
    }
}
