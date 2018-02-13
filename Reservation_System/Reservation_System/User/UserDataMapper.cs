using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Reservation_System.User
{
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
                        UserLogin.CommandText = "Select * from USERS where U_USERNAME=@user COLLATE latin1_general_cs and U_PASSWORD=@password COLLATE latin1_general_cs";
                        UserLogin.Parameters.AddWithValue("@user", username);
                        UserLogin.Parameters.AddWithValue("@password", password);
                        
                        // Use ExecuteReader when you expect the query to return a row, or rows
                        MySqlDataReader reader = UserLogin.ExecuteReader();

                        // Check if the query did not return a row/record of data
                        if (!reader.HasRows)
                        {
                            return null;
                        }

                        // Get the row/record from the data reader
                        reader.Read();
                        
                        // Create the User object, with the saved game values
                        User = User.CreateUser(username, (int)reader["U_ID"], (int)reader["U_ACCOUNTTYPE"]);
                    }                    
                    return User;
                }
            }
            catch (Exception)
            {
                // Ignore errors. If there is an error, this function will return a "null" User.
            }

            return null;
        }

        /*
        public static void SaveToDatabase(User User)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    // Open the connection, so we can perform MySql commands
                    connection.Open();

                    // Insert/Update data in SavedGame table
                    using (MySqlCommand existingRowCountCommand = connection.CreateCommand())
                    {
                        existingRowCountCommand.CommandType = CommandType.Text;
                        existingRowCountCommand.CommandText = "SELECT count(*) FROM SavedGame";

                        // Use ExecuteScalar when your query will return one value
                        int existingRowCount = (int)existingRowCountCommand.ExecuteScalar();

                        if (existingRowCount == 0)
                        {
                            // There is no existing row, so do an INSERT
                            using (MySqlCommand insertSavedGame = connection.CreateCommand())
                            {
                                insertSavedGame.CommandType = CommandType.Text;
                                insertSavedGame.CommandText =
                                    "INSERT INTO SavedGame " +
                                    "(CurrentHitPoints, MaximumHitPoints, Gold, ExperiencePoints, CurrentLocationID) " +
                                    "VALUES " +
                                    "(@CurrentHitPoints, @MaximumHitPoints, @Gold, @ExperiencePoints, @CurrentLocationID)";

                                // Pass the values from the User object, to the MySql query, using parameters
                                insertSavedGame.Parameters.Add("@CurrentHitPoints", MySqlDbType.Int);
                                insertSavedGame.Parameters["@CurrentHitPoints"].Value = User.CurrentHitPoints;
                                insertSavedGame.Parameters.Add("@MaximumHitPoints", MySqlDbType.Int);
                                insertSavedGame.Parameters["@MaximumHitPoints"].Value = User.MaximumHitPoints;
                                insertSavedGame.Parameters.Add("@Gold", MySqlDbType.Int);
                                insertSavedGame.Parameters["@Gold"].Value = User.Gold;
                                insertSavedGame.Parameters.Add("@ExperiencePoints", MySqlDbType.Int);
                                insertSavedGame.Parameters["@ExperiencePoints"].Value = User.ExperiencePoints;
                                insertSavedGame.Parameters.Add("@CurrentLocationID", MySqlDbType.Int);
                                insertSavedGame.Parameters["@CurrentLocationID"].Value = User.CurrentLocation.ID;

                                // Perform the MySql command.
                                // Use ExecuteNonQuery, because this query does not return any results.
                                insertSavedGame.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // There is an existing row, so do an UPDATE
                            using (MySqlCommand updateSavedGame = connection.CreateCommand())
                            {
                                updateSavedGame.CommandType = CommandType.Text;
                                updateSavedGame.CommandText =
                                    "UPDATE SavedGame " +
                                    "SET CurrentHitPoints = @CurrentHitPoints, " +
                                    "MaximumHitPoints = @MaximumHitPoints, " +
                                    "Gold = @Gold, " +
                                    "ExperiencePoints = @ExperiencePoints, " +
                                    "CurrentLocationID = @CurrentLocationID";

                                // Pass the values from the User object, to the MySql query, using parameters
                                // Using parameters helps make your program more secure.
                                // It will prevent MySql injection attacks.
                                updateSavedGame.Parameters.Add("@CurrentHitPoints", MySqlDbType.Int);
                                updateSavedGame.Parameters["@CurrentHitPoints"].Value = User.CurrentHitPoints;
                                updateSavedGame.Parameters.Add("@MaximumHitPoints", MySqlDbType.Int);
                                updateSavedGame.Parameters["@MaximumHitPoints"].Value = User.MaximumHitPoints;
                                updateSavedGame.Parameters.Add("@Gold", MySqlDbType.Int);
                                updateSavedGame.Parameters["@Gold"].Value = User.Gold;
                                updateSavedGame.Parameters.Add("@ExperiencePoints", MySqlDbType.Int);
                                updateSavedGame.Parameters["@ExperiencePoints"].Value = User.ExperiencePoints;
                                updateSavedGame.Parameters.Add("@CurrentLocationID", MySqlDbType.Int);
                                updateSavedGame.Parameters["@CurrentLocationID"].Value = User.CurrentLocation.ID;

                                // Perform the MySql command.
                                // Use ExecuteNonQuery, because this query does not return any results.
                                updateSavedGame.ExecuteNonQuery();
                            }
                        }
                    }

                    // The Quest and Inventory tables might have more, or less, rows in the database
                    // than what the User has in their properties.
                    // So, when we save the User's game, we will delete all the old rows
                    // and add in all new rows.
                    // This is easier than trying to add/delete/update each individual rows

                    // Delete existing Quest rows
                    using (MySqlCommand deleteQuestsCommand = connection.CreateCommand())
                    {
                        deleteQuestsCommand.CommandType = CommandType.Text;
                        deleteQuestsCommand.CommandText = "DELETE FROM Quest";

                        deleteQuestsCommand.ExecuteNonQuery();
                    }

                    // Insert Quest rows, from the User object
                    foreach (UserQuest UserQuest in User.Quests)
                    {
                        using (MySqlCommand insertQuestCommand = connection.CreateCommand())
                        {
                            insertQuestCommand.CommandType = CommandType.Text;
                            insertQuestCommand.CommandText = "INSERT INTO Quest (QuestID, IsCompleted) VALUES (@QuestID, @IsCompleted)";

                            insertQuestCommand.Parameters.Add("@QuestID", MySqlDbType.Int);
                            insertQuestCommand.Parameters["@QuestID"].Value = UserQuest.Details.ID;
                            insertQuestCommand.Parameters.Add("@IsCompleted", MySqlDbType.Bit);
                            insertQuestCommand.Parameters["@IsCompleted"].Value = UserQuest.IsCompleted;

                            insertQuestCommand.ExecuteNonQuery();
                        }
                    }

                    // Delete existing Inventory rows
                    using (MySqlCommand deleteInventoryCommand = connection.CreateCommand())
                    {
                        deleteInventoryCommand.CommandType = CommandType.Text;
                        deleteInventoryCommand.CommandText = "DELETE FROM Inventory";

                        deleteInventoryCommand.ExecuteNonQuery();
                    }

                    // Insert Inventory rows, from the User object
                    foreach (Loan Loan in User.Loans)
                    {
                        using (MySqlCommand insertInventoryCommand = connection.CreateCommand())
                        {
                            insertInventoryCommand.CommandType = CommandType.Text;
                            insertInventoryCommand.CommandText = "INSERT INTO Inventory (InventoryItemID, Quantity) VALUES (@InventoryItemID, @Quantity)";

                            insertInventoryCommand.Parameters.Add("@InventoryItemID", MySqlDbType.Int16);
                            insertInventoryCommand.Parameters["@InventoryItemID"].Value = Loan.Details.ID;                          

                            insertInventoryCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }
        */
    }
 }