using DAL.Interfaces;
using Entities.Utils;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NequiAccountService
    {
        private readonly INequiAccountRepository _nequiAccountRepository;

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
                return new Response { Success = false, Message = "Contraseña inválida. (4 caracteres)" };
            }

            if (!ValidationHelper.IsBalanceValid(account.AvailableBalance))
            {
                return new Response { Success = false, Message = "Saldo inválido. (Mayor o igual a 0)" };
            }

            try
            {
                _nequiAccountRepository.Add(account);
                return new Response { Success = true, Message = "Cuenta Nequi registrada con éxito." };
            }
            catch (Exception ex)
            {
                return new Response { Success = false, Message = ex.Message };
            }

        }

        public NequiAccount GetNequiAccount(int id)
        {
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
            return _nequiAccountRepository.GetAccountByPhoneNumber(phoneNumber);
        }

        public Response AuthenticateNequiAccount(string phoneNumber, string password)
        {
            if (!ValidationHelper.IsPasswordNequiValid(password))
            {
                return new Response { Success = false, Message = "Contraseña inválida. (4 caracteres)" };
            }

            var account = GetAccountByPhoneNumber(phoneNumber);
            if (account == null)
            {
                return new Response { Success = false, Message = "Número de teléfono no registrado." };
            }

            if (account.Password == password)
            {
                return new Response { Success = true, Message = "Autenticación satisfactoria." };
            }

            return new Response { Success = false, Message = "Contraseña incorrecta." };
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
            if (account == null)
            {
                return new Response { Success = false, Message = "Cuenta no puede ser nula a la hora de eliminar una clave dinamica." };
            }

            ///// NO PONERLA NULAPORQUE DA ERROR
            account.DynamicKey = string.Empty;

            _nequiAccountRepository.Update(account);

            return new Response { Success = true, Message = $"Clave dinámica eliminada con éxito al usuario {account.AccountHolderName}" };
        }

        //public async Task<Response> ProcessDinamicKeyToNequiAccount(NequiAccount account)
        //{
        //    if (account == null)
        //    {
        //        return new Response { Success = false, Message = "Cuenta no puede ser nula a la hora de procesar una clave dinamica." };
        //    }

        //    var saveDynamicKey = SaveDinamicKeyToNequiAccount(account);

        //    await Task.Delay(10000);

        //    var deleteDynamicKey = DeleteDinamicKeyToNequiAccount(account);

        //    if (!saveDynamicKey.Success || !deleteDynamicKey.Success)
        //    {
        //        return new Response { Success = false, Message = "Ha ocurrido un inconveniente en el proceso de clave de dinámica." };
        //    }

        //    var updatedAccount = GetAccountByPhoneNumber(account.AccountNumber);

        //    return new Response { Success = false, Message = "Proceso de clave de dinámica realizado correctamente." };
        //}

        private string GenerateDynamicKey()
        {
            var random = new Random();
            return random.Next(100000, 999999).ToString();
        }
    }
}
