using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface INequiAccountRepository
    {
        void Add(NequiAccount card);
        NequiAccount GetById(int id);
        void Update(NequiAccount account);
        void Delete(int id);
        NequiAccount GetAccountByPhoneNumber(string phoneNumber);
    }
}
