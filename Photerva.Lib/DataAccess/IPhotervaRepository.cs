using Photerva.Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Photerva.Lib.DataAccess
{
    public interface IPhotervaRepository
    {
        List<Customer> GetCustomers(string ownerID);
    }
}
