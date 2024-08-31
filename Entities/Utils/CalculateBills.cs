using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Utils
{
    public static class CalculateBills
    {
        private static readonly int[] typesBills = { 10_000, 20_000, 50_000, 100_000 };

        public static Dictionary<int, int> CalculateBillsQuantity(int requestedAmount)
        {
            Dictionary<int, int> billsCount = InitializeMapBills();
            int position = 0;

            while (requestedAmount > 0)
            {
                int bill = typesBills[position];
                int index = position;

                while (index < typesBills.Length &&
                       bill <= requestedAmount &&
                       requestedAmount > 0)
                {
                    billsCount[bill] += 1;
                    requestedAmount -= bill;
                    bill = typesBills[++index % typesBills.Length];
                }

                position = ++position % typesBills.Length;
            }

            return billsCount;
        }

        private static Dictionary<int, int> InitializeMapBills()
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (int typeBill in typesBills)
            {
                map[typeBill] = 0;
            }
            return map;
        }
    }
}
