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
            var billsCount = new Dictionary<int, int>();
            foreach (int typeBill in typesBills)
            {
                billsCount[typeBill] = 0;
            }

            // Inicio del acarreo
            int startIndex = 0;

            while (requestedAmount > 0)
            {
                for (int i = startIndex; i < typesBills.Length; i++)
                {
                    int bill = typesBills[i];

                    if (requestedAmount >= bill)
                    {
                        billsCount[bill]++;
                        requestedAmount -= bill;
                    }
                }

                startIndex = (startIndex + 1) % typesBills.Length;
            }

            return billsCount;
        }

    }
}
