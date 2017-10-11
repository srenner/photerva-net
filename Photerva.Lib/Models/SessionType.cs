using System;
using System.Collections.Generic;
using System.Text;

namespace Photerva.Lib.Models
{
    public class SessionType
    {
        public int SessionTypeID { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public decimal BasePrice { get; set; }
        public TimeSpan ShootTime { get; set; }
        public TimeSpan EditTime { get; set; }

        public string OwnerID { get; set; }
        public ApplicationUser Owner { get; set; }
    }
}
