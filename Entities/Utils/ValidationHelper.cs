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
            return cardNumber.Length == 16 && cardNumber.All(char.IsDigit);
        }

        public static bool IsPhoneNumberValid(string phoneNumber)
        {
            return phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit);
        }

        public static bool IsPhoneInitWithZero(string phoneNumber)
        {
            return phoneNumber.StartsWith("0");
        }

        public static bool IsDynamicKeyValid(string dynamicKey)
        {
            return dynamicKey.Length == 6 && dynamicKey.All(char.IsDigit);
        }

        public static bool IsPasswordValid(string password)
        {
            return password.Length == 4 && password.All(char.IsDigit);
        }

        public static bool IsPasswordNequiValid(string password)
        {
            return password.Length == 4 && password.All(char.IsDigit);
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
