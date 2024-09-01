using DAL;
using DAL.Interfaces;
using Entities;
using Entities.Utils;
using System;

using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DebitCardService
    {
        private readonly IDebitCardRepository _debitCardRepository;
        private int failedAttempts = 0;

        public DebitCardService(IDebitCardRepository debitCardRepository)
        {
            _debitCardRepository = debitCardRepository;
        }

        public Response AddDebitCard(DebitCard card)
        {
            // Validaciones
            var cardExist = GetDebitCardByNumber(card.CardNumber);

            if(cardExist != null)
            {
                return new Response { Success = false, Message = "Número de tarjeta ya existe." };
            }

            if (!ValidationHelper.IsPasswordValid(card.Password))
            {
                return new Response { Success = false, Message = "Contraseña inválida. (Mínimo 8 caracteres)" };
            }

            if (!ValidationHelper.IsBalanceValid(card.AvailableBalance))
            {
                return new Response { Success = false, Message = "Saldo inválido. (Mayor o igual a 0)" };
            }

            try
            {
                _debitCardRepository.Add(card);
                return new Response { Success = true, Message = "Tarjeta débito registrada con éxito." };
            }
            catch (Exception ex)
            {
                return new Response { Success = false, Message = ex.Message };
            }

        }

        public DebitCard GetDebitCard(int id)
        {
            return _debitCardRepository.GetById(id);
        }
        
        public Response RechargeDebitCard(string cardNumber, Decimal rechargeAmount)
        {
            var updateCard = GetDebitCardByNumber(cardNumber);

            if (!ValidationHelper.IsBalanceValid(rechargeAmount))
            {
                return new Response { Success = false, Message = "Saldo inválido. (Mayor a 0)" };
            }

            updateCard.AvailableBalance += rechargeAmount;
            _debitCardRepository.Update(updateCard);
            return new Response { Success = true, Message = "Saldo adicionado con éxito." };
        }

        // Cuando vaya a retirar validar que el monto sea mayor o igual al actual
        public Response WithdrawDebitCard(DebitCard debitCard, Decimal withdrawAmount)
        {
            if (withdrawAmount > debitCard.AvailableBalance)
            {
                return new Response { Success = false, Message = "El monto a retirar no puede ser mayor al disponible." };
            }

            debitCard.AvailableBalance -= withdrawAmount;
            _debitCardRepository.Update(debitCard);
            return new Response { Success = true, Message = "Saldo retirado con éxito." };
        }

        public void DeleteDebitCard(int id)
        {
            _debitCardRepository.Delete(id);
        }

        public DebitCard GetDebitCardByNumber(string cardNumber)
        {
            return _debitCardRepository.GetCardByNumber(cardNumber);
        }

        public Response AuthenticateDebitCard(string cardNumber, string password)
        {
            if (!ValidationHelper.IsPasswordValid(password))
            {
                return new Response { Success = false, Message = "Contraseña inválida. (Mínimo 8 caracteres)" };
            }

            var card = GetDebitCardByNumber(cardNumber);
            if (card == null)
            {
                return new Response { Success = false, Message = "Número de tarjeta no registrado." };
            }

            if (card.IsBlocked)
            {
                return new Response { Success = false, Message = "La tarjeta está bloqueada." };
            }

            if (card.Password == password)
            {
                failedAttempts = 0;
                return new Response { Success = true, Message = "Autenticación satisfactoria." };
            }
            else
            {
                failedAttempts++;
            }

            if (failedAttempts >= 3)
            {
                card.IsBlocked = true;
                _debitCardRepository.Update(card);
                return new Response { Success = false, Message = "La tarjeta ha sido bloqueada por múltiples intentos fallidos." };
            }
            
            return new Response { Success = false, Message = $"Contraseña incorrecta.\nSi falla {3 - failedAttempts} veces más se bloqueará la tarjeta." };
        }
    }
}
