using DAL.Interfaces;
using Entities.Utils;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Security.Principal;

namespace BLL
{
    public class NequiAccountService
    {
        private readonly INequiAccountRepository _nequiAccountRepository;
        private int failedAttempts = 0;

        public NequiAccountService(INequiAccountRepository nequiAccountRepository)
        {
            _nequiAccountRepository = nequiAccountRepository;
        }

        public Response AddNequiAccount(NequiAccount account)
        {
            // Validaciones
            var accountExist = GetAccountByPhoneNumber(account.AccountNumber);

            if (accountExist != null)
            {
                return new Response { Success = false, Message = "Número de teléfono ya está registrado en otra cuenta." };
            }

            if (!ValidationHelper.IsPasswordNequiValid(account.Password))
            {
                return new Response { Success = false, Message = "Contraseña inválida. (4 dígitos)" };
            }

            if (!ValidationHelper.IsBalanceValid(account.AvailableBalance))
            {
                return new Response { Success = false, Message = "Saldo inválido. (Mayor o igual a 0)" };
            }

            if (ValidationHelper.IsPhoneInitWithZero(account.AccountNumber))
            {
                return new Response { Success = false, Message = "El número no puede iniciar por 0." };
            }

            try
            {
                //account.AccountNumber = "0" + account.AccountNumber;
                _nequiAccountRepository.Add(account);
                return new Response { Success = true, Message = "Cuenta Nequi registrada con éxito." };
            }
            catch (Exception ex)
            {
                return new Response { Success = false, Message = ex.Message };
            }

        }

        public NequiAccount GetNequiAccountById(int id)
        {
            //var account = _nequiAccountRepository.GetById(id);

            //if (account != null && account.AccountNumber.StartsWith("0"))
            //{
            //    account.AccountNumber = account.AccountNumber.Substring(1);
            //}

            //return account;

            return _nequiAccountRepository.GetById(id);
        }



        public Response RechargeNequiAccount(string phoneNumber, Decimal rechargeAmount)
        {
            var updateAccount = GetAccountByPhoneNumber(phoneNumber);

            if (!ValidationHelper.IsBalanceValid(rechargeAmount))
            {
                return new Response { Success = false, Message = "Saldo inválido. (Mayor a 0)" };
            }

            updateAccount.AvailableBalance += rechargeAmount;
            _nequiAccountRepository.Update(updateAccount);
            return new Response { Success = true, Message = "Saldo adicionado con éxito." };
        }

        // Cuando vaya a retirar validar que el monto sea mayor o igual al actual
        public Response WithdrawNequiAccount(NequiAccount account, Decimal withdrawAmount)
        {
            if (withdrawAmount > account.AvailableBalance)
            {
                return new Response { Success = false, Message = "El monto a retirar no puede ser mayor al disponible." };
            }

            account.AvailableBalance -= withdrawAmount;
            _nequiAccountRepository.Update(account);
            return new Response { Success = true, Message = "Saldo retirado con éxito." };
        }

        public void DeleteNequiAccount(int id)
        {
            _nequiAccountRepository.Delete(id);
        }

        public NequiAccount GetAccountByPhoneNumber(string phoneNumber)
        {
            //string formattedPhoneNumber = "0" + phoneNumber;
            //var account = _nequiAccountRepository.GetAccountByPhoneNumber(formattedPhoneNumber);

            // Si se encuentra la cuenta, eliminar el '0' al devolver el número
            //if (account != null && account.AccountNumber.StartsWith("0"))
            //{
            //    account.AccountNumber = account.AccountNumber.Substring(1);
            //}

            //return account;

            return _nequiAccountRepository.GetAccountByPhoneNumber(phoneNumber);
        }

        public Response AuthenticateNequiAccount(string phoneNumber, string password)
        {
            if (!ValidationHelper.IsPasswordNequiValid(password))
            {
                return new Response { Success = false, Message = "Contraseña inválida. (4 dígitos)" };
            }

            var account = GetAccountByPhoneNumber(phoneNumber);
            if (account == null)
            {
                return new Response { Success = false, Message = "Número de teléfono no registrado." };
            }

            if (account.IsBlocked)
            {
                return new Response { Success = false, Message = "La cuenta está bloqueada." };
            }

            if (account.Password == password)
            {

                return new Response { Success = true, Message = "Autenticación satisfactoria." };
            }

            return new Response { Success = false, Message = "Contraseña incorrecta." };
        }

        public Response AuntenticatWithDynamicKey(string phoneNumber, string password, string dynamicKey)
        {
            var response = AuthenticateNequiAccount(phoneNumber, password);
            var nequiAccount = GetAccountByPhoneNumber(phoneNumber);

            if (!response.Success)
            {
                return response;
            }

            if (dynamicKey == nequiAccount.DynamicKey)
            {
                failedAttempts = 0;
                return new Response { Success = true, Message = $"Clave dinámica correcta." };

            }
            else
            {
                failedAttempts++;
            }

            if (failedAttempts >= 3)
            {
                nequiAccount.IsBlocked = true;
                _nequiAccountRepository.Update(nequiAccount);
                return new Response { Success = false, Message = "La cuenta ha sido bloqueada por múltiples intentos fallidos." };
            }

            return new Response { Success = false, Message = $"Clave dinámica incorrecta.\nSi falla {3 - failedAttempts} veces más se bloqueará la cuenta." };
        }

        public Response SaveDinamicKeyToNequiAccount(NequiAccount account)
        {
            if (account == null)
            {
                return new Response { Success = false, Message = "Cuenta no puede ser nula a la hora de guardar una clave dinamica." };
            }

            string dynamicKey = GenerateDynamicKey();

            account.DynamicKey = dynamicKey;

            _nequiAccountRepository.Update(account);

            return new Response { Success = true, Message = $"Clave dinámica añadida con éxito al usuario {account.AccountHolderName}" };
        }

        public Response DeleteDinamicKeyToNequiAccount(NequiAccount account)
        {
            // en caso de que se haga una retiro en el tiempo, toca actualizar el saldo 
            var nequiAccount = _nequiAccountRepository.GetAccountByPhoneNumber(account.AccountNumber);

            if (nequiAccount == null)
            {
                return new Response { Success = false, Message = "Cuenta no puede ser nula a la hora de eliminar una clave dinamica." };
            }

            nequiAccount.DynamicKey = string.Empty;

            _nequiAccountRepository.Update(nequiAccount);

            return new Response { Success = true, Message = $"Clave dinámica eliminada con éxito al usuario {account.AccountHolderName}" };
        }

        private string GenerateDynamicKey()
        {
            var random = new Random();
            return random.Next(100000, 999999).ToString();
        }
    }
}
