using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NequiAccountRepository
    {
        private readonly DatabaseConnection _databaseConnection;

        public NequiAccountRepository()
        {
            _databaseConnection = new DatabaseConnection();
        }

        public void Add(NequiAccount account)
        {
            using (var connection = _databaseConnection.GetConnection())
            {
                connection.Open();
                var command = new MySqlCommand("INSERT INTO NequiAccounts (account_holder_name, account_number, account_password, available_balance, dynamic_key) VALUES (@holderName, @number, @password, @balance, @dynamicKey)", connection);

                command.Parameters.AddWithValue("@holderName", account.AccountHolderName);
                command.Parameters.AddWithValue("@number", account.AccountNumber);
                command.Parameters.AddWithValue("@password", account.Password);
                command.Parameters.AddWithValue("@balance", account.AvailableBalance);
                command.Parameters.AddWithValue("@dynamicKey", account.DynamicKey);

                command.ExecuteNonQuery();
            }
        }

        public NequiAccount Get(int id)
        {
            using (var connection = _databaseConnection.GetConnection())
            {
                connection.Open();
                var command = new MySqlCommand("SELECT * FROM NequiAccounts WHERE id = @id", connection);
                command.Parameters.AddWithValue("@id", id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new NequiAccount
                        {
                            Id = reader.GetInt32("id"),
                            AccountHolderName = reader.GetString("account_holder_name"),
                            AccountNumber = reader.GetString("account_number"),
                            Password = reader.GetString("account_password"),
                            AvailableBalance = reader.GetDecimal("available_balance"),
                            DynamicKey = reader.IsDBNull(reader.GetOrdinal("dynamic_key")) ? null : reader.GetString("dynamic_key"),
                            CreationDate = reader.GetDateTime("created_at")
                        };
                    }
                    return null;
                }
            }
        }

        public void Update(NequiAccount account)
        {
            using (var connection = _databaseConnection.GetConnection())
            {
                connection.Open();
                var command = new MySqlCommand("UPDATE NequiAccounts SET account_holder_name = @holderName, account_number = @number, account_password = @password, available_balance = @balance, dynamic_key = @dynamicKey WHERE id = @id", connection);

                command.Parameters.AddWithValue("@holderName", account.AccountHolderName);
                command.Parameters.AddWithValue("@number", account.AccountNumber);
                command.Parameters.AddWithValue("@password", account.Password);
                command.Parameters.AddWithValue("@balance", account.AvailableBalance);
                command.Parameters.AddWithValue("@dynamicKey", account.DynamicKey);
                command.Parameters.AddWithValue("@id", account.Id);

                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = _databaseConnection.GetConnection())
            {
                connection.Open();
                var command = new MySqlCommand("DELETE FROM NequiAccounts WHERE id = @id", connection);
                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
            }
        }
    }
}
