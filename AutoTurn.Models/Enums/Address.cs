using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTurn.Models.Enums
{
    public class Address
    {
        public string Province { get; set; } = string.Empty;
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public int? ForeignId { get; set; } = null;
    }
}
