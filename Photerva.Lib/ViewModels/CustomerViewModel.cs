using System;
using System.Collections.Generic;
using System.Text;

namespace Photerva.Lib.ViewModels
{
    public class CustomerViewModel
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public bool Deleted { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
