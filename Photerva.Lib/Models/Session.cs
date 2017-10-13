using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Photerva.Lib.Models
{
    public class Session
    {
        public int SessionID { get; set; }

        public int SessionTypeID { get; set; }
        public SessionType SessionType { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        [Column(TypeName = "Money")]
        public decimal? QuotedPrice { get; set; }
        [Column(TypeName = "Money")]
        public decimal? FinalPrice { get; set; }
        [Column(TypeName = "Money")]
        public decimal? Expenses { get; set; }

        public TimeSpan? ShootTime { get; set; }
        public TimeSpan? EditTime { get; set; }

        public DateTime? ScheduledDate { get; set; }
        public DateTime? BackupDate { get; set; }

        public string Notes { get; set; }
        public bool Deleted { get; set; }

        public DateTime DateAdded { get; set; }
        public DateTime DateUpdated { get; set; }

        public string OwnerID { get; set; }
        public ApplicationUser Owner { get; set; }
    }
}
