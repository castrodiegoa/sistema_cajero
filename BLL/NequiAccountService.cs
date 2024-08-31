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

            if (!ValidationHelper.IsPasswordValid(account.Password))
            {
                return new Response { Success = false, Message = "Contraseña inválida. (Mínimo 8 caracteres)" };
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

        public Response AuthenticateNequiAccount(string cardNumber, string password)
        {
            if (!ValidationHelper.IsPasswordNequiValid(password))
            {
                return new Response { Success = false, Message = "Contraseña inválida. (4 caracteres)" };
            }

            var card = GetAccountByPhoneNumber(cardNumber);
            if (card == null)
            {
                return new Response { Success = false, Message = "Número de teléfono no registrado." };
            }

            if (card.Password == password)
            {
                return new Response { Success = true, Message = "Autenticación satisfactoria." };
            }

            return new Response { Success = false, Message = "Contraseña incorrecta." };
        }
    }
}
