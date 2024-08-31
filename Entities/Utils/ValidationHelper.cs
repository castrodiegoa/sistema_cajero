using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public static class ValidationHelper
    {
        public static bool IsCardNumberValid(string cardNumber)
        {
            return cardNumber.Length == 11 && cardNumber.All(char.IsDigit);
        }

        public static bool IsPhoneNumberValid(string phoneNumber)
        {
            return phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit);
        }

        public static bool IsPasswordValid(string password)
        {
            return password.Length >= 8;
        }

        public static bool IsPasswordNequiValid(string password)
        {
            return password.Length == 4;
        }

        public static bool IsBalanceValid(decimal balance)
        {
            return balance >= 0;
        }

        public static bool ValidateNotEmpty(params string[] fields)
        {
            foreach (var field in fields)
            {
                if (string.IsNullOrWhiteSpace(field))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
