using Entities;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;

namespace DAL
{
    public class DebitCardRepository : IDebitCardRepository
    {
        private readonly DatabaseConnection _databaseConnection;

        public DebitCardRepository()
        {
            _databaseConnection = new DatabaseConnection();
        }

        public void Add(DebitCard card)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    connection.Open();
                    var command = new MySqlCommand(
                        "INSERT INTO DebitCards (cardholder_name, card_number, card_password, available_balance, isBlocked) " +
                        "VALUES (@holderName, @number, @password, @balance, @isBlocked)", connection);

                    command.Parameters.AddWithValue("@holderName", card.CardHolderName);
                    command.Parameters.AddWithValue("@number", card.CardNumber);
                    command.Parameters.AddWithValue("@password", card.Password);
                    command.Parameters.AddWithValue("@balance", card.AvailableBalance);
                    command.Parameters.AddWithValue("@isBlocked", card.IsBlocked);

                    command.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException("Ocurrió un error al guardar la tarjeta de débito en la base de datos.", ex);
            }
        }

        public DebitCard GetById(int id)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    connection.Open();
                    var command = new MySqlCommand("SELECT * FROM DebitCards WHERE id = @id", connection);
                    command.Parameters.AddWithValue("@id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new DebitCard
                            {
                                Id = reader.GetInt32("id"),
                                CardHolderName = reader.GetString("cardholder_name"),
                                CardNumber = reader.GetString("card_number"),
                                Password = reader.GetString("card_password"),
                                AvailableBalance = reader.GetDecimal("available_balance"),
                                IsBlocked = reader.GetBoolean("isBlocked"), // Leer el estado de bloqueo
                                CreationDate = reader.GetDateTime("created_at")
                            };
                        }
                        return null;
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException("Ocurrió un error al buscar por id la tarjeta de débito en la base de datos.", ex);
            }
        }

        public void Update(DebitCard card)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    connection.Open();
                    var command = new MySqlCommand(
                        "UPDATE DebitCards SET cardholder_name = @holderName, card_number = @number, card_password = @password, " +
                        "available_balance = @balance, isBlocked = @isBlocked WHERE id = @id", connection);

                    command.Parameters.AddWithValue("@holderName", card.CardHolderName);
                    command.Parameters.AddWithValue("@number", card.CardNumber);
                    command.Parameters.AddWithValue("@password", card.Password);
                    command.Parameters.AddWithValue("@balance", card.AvailableBalance);
                    command.Parameters.AddWithValue("@isBlocked", card.IsBlocked); // Actualiza el estado de bloqueo
                    command.Parameters.AddWithValue("@id", card.Id);

                    command.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException("Ocurrió un error al actualizar la tarjeta de débito en la base de datos.", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    connection.Open();
                    var command = new MySqlCommand("DELETE FROM DebitCards WHERE id = @id", connection);
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException("Ocurrió un error al eliminar la tarjeta de débito en la base de datos.", ex);
            }
        }

        public DebitCard GetCardByNumber(string cardNumber)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    connection.Open();
                    var command = new MySqlCommand("SELECT * FROM DebitCards WHERE card_number = @cardNumber", connection);
                    command.Parameters.AddWithValue("@cardNumber", cardNumber);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new DebitCard
                            {
                                Id = reader.GetInt32("id"),
                                CardHolderName = reader.GetString("cardholder_name"),
                                CardNumber = reader.GetString("card_number"),
                                Password = reader.GetString("card_password"),
                                AvailableBalance = reader.GetDecimal("available_balance"),
                                IsBlocked = reader.GetBoolean("isBlocked"), // Leer el estado de bloqueo
                                CreationDate = reader.GetDateTime("created_at")
                            };
                        }
                        return null;
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException("Ocurrió un error al buscar por número de tarjeta de débito en la base de datos.", ex);
            }
        }
    }
}
