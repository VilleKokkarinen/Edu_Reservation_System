using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;

namespace Reservation_System.User
{
    public sealed class PasswordHash
    {
        const int SaltSize = 16, HashSize = 20, HashIter = 10000;
        readonly byte[] _salt, _hash;
        public PasswordHash(string password)
        {
            new RNGCryptoServiceProvider().GetBytes(_salt = new byte[SaltSize]);
            _hash = new Rfc2898DeriveBytes(password, _salt, HashIter).GetBytes(HashSize);
        }
        public PasswordHash(byte[] hashBytes)
        {
            Array.Copy(hashBytes, 0, _salt = new byte[SaltSize], 0, SaltSize);
            Array.Copy(hashBytes, SaltSize, _hash = new byte[HashSize], 0, HashSize);
        }
        public PasswordHash(byte[] salt, byte[] hash)
        {
            Array.Copy(salt, 0, _salt = new byte[SaltSize], 0, SaltSize);
            Array.Copy(hash, 0, _hash = new byte[HashSize], 0, HashSize);
        }
        public byte[] ToArray()
        {
            byte[] hashBytes = new byte[SaltSize + HashSize];
            Array.Copy(_salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(_hash, 0, hashBytes, SaltSize, HashSize);
            return hashBytes;
        }
        public byte[] Salt { get { return (byte[])_salt.Clone(); } }
        public byte[] Hash { get { return (byte[])_hash.Clone(); } }
        public bool Verify(string password)
        {
            byte[] test = new Rfc2898DeriveBytes(password, _salt, HashIter).GetBytes(HashSize);
            for (int i = 0; i < HashSize; i++)
                if (test[i] != _hash[i])
                    return false;
            return true;
        }
    }
    class UserDataMapper
    {
        private static readonly string _connectionString = "SERVER=10.12.132.34;DATABASE=Ville_Kokkarinen_OHTU;UID=p119980;PASSWORD=12345;";

        public static User CreateFromDatabase(string username, string password)
        {
            try
            {
                // This is our connection to the database
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    // Open the connection, so we can perform MySql commands
                    connection.Open();

                    User User;
                    using (MySqlCommand UserLogin = connection.CreateCommand())
                    {
                        UserLogin.CommandType = CommandType.Text;
                        UserLogin.CommandText = "Select * from USERS where U_USERNAME=@user COLLATE latin1_general_cs";
                        UserLogin.Parameters.AddWithValue("@user", username);

                        // Use ExecuteReader when you expect the query to return a row, or rows
                        MySqlDataReader reader = UserLogin.ExecuteReader();

                        // Check if the query did not return a row/record of data
                        if (!reader.HasRows)
                        {
                            return null;
                        }

                        // Get the row/record from the data reader
                        reader.Read();

                        byte[] hashBytes = (byte[])reader["U_PASSWORD"];
                        PasswordHash hash = new PasswordHash(hashBytes);
                        if (!hash.Verify(password))
                            throw new UnauthorizedAccessException();

                        // Create the User object, with the saved game values
                        User = User.CreateUser(username, (int)reader["U_ID"], (int)reader["U_ACCOUNTTYPE"]);
                    }
                    return User;
                }
            }
            catch (Exception)
            { }

            return null;
        }        
    }
 }