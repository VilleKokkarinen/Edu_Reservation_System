using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation_System
{
    class SQL
    {
       

        public MySqlConnection MySqlConnection()
        {
            string server = "10.12.132.34";
            string database = "Ville_Kokkarinen_OHTU";
            string uid = "p119980";
            string password = "12345";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }
        public MySqlCommand MySqlLogin(string user, string password, MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("Select * from USERS where U_USERNAME=@user and U_PASSWORD=@password", connection);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@password", password);

            return cmd;
        }
        public MySqlCommand MySqlForgotPassword(string user, string email, MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("Select * from USERS where U_USERNAME=@user and U_EMAIL=@email", connection);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@email", email);

            return cmd;
        }
        public MySqlCommand MySqlChangePassword(string user, string newpassword, MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE USERS SET U_PASSWORD =@newpassword where U_USERNAME=@user", connection);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@newpassword", newpassword);

            return cmd;
        }
        public MySqlCommand MySqlGetAvailableItems(MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("select ITEMS.I_NAME, ITEMS.I_ID from ITEMS where ITEMS.I_STATE=\"1\"", connection);
            return cmd;
        }

        public MySqlCommand MySqlGetItemTypes(MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("select * from ITEMSTATE", connection);            
            return cmd;
        }

    }
}
