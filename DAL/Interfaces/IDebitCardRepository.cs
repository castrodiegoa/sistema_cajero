using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IDebitCardRepository
    {
        void Add(DebitCard card);
        DebitCard GetById(int id);
        void Update(DebitCard card);
        void Delete(int id);
        DebitCard GetCardByNumber(string cardNumber);
    }
}
