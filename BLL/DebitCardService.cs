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

        public DebitCardService(IDebitCardRepository debitCardRepository)
        {
            _debitCardRepository = debitCardRepository;
        }

        public Response AddDebitCard(DebitCard card)
        {
            // Validaciones
            if (!ValidationHelper.IsCardNumberValid(card.CardNumber))
            {
                return new Response { Success = false, Message = "Número de tarjeta inválido. (16 dígitos númericos)" };
            }

            if (!ValidationHelper.IsPasswordValid(card.Password))
            {
                return new Response { Success = false, Message = "Contraseña inválida. (Mínimo 8 caracteres)" };
            }

            if (!ValidationHelper.IsBalanceValid(card.AvailableBalance))
            {
                return new Response { Success = false, Message = "Saldo inválido. (Mayor a 0)" };
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
            // Validaciones
            if (!ValidationHelper.IsCardNumberValid(cardNumber))
            {
                return null;
            }

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

            if (card.Password == password)
            {
                return new Response { Success = true, Message = "Autenticación satisfactoria." };
            }

            return new Response { Success = false, Message = "Contraseña incorrecta." };
        }

        // **** 

        private static readonly int[] typesBills = { 10_000, 20_000, 50_000, 100_000 };

        public Dictionary<int, int> CalculateBillsQuantity(int requestedAmount)
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

        private Dictionary<int, int> InitializeMapBills()
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
