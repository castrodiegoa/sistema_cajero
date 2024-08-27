using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class NequiAccount
    {
        public int Id { get; set; }
        public string AccountHolderName { get; set; }
        public string AccountNumber { get; set; }
        public string Password { get; set; }
        public decimal AvailableBalance { get; set; }
        public DateTime CreationDate { get; set; }
        public string DynamicKey { get; set; } = string.Empty;  // Puede ser nulo
    }

}
