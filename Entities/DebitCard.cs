using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DebitCard
    {
        public int Id { get; set; }
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string Password { get; set; }
        public decimal AvailableBalance { get; set; }
        public DateTime CreationDate { get; set; }
    }

}
