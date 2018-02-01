using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation_System
{
    class SQL
    {
        string access = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Access\reservationsystem.mdb";
        string Firebird = @"User=SYSDBA;Password=kokkarinen;Database=192.168.43.227:D:\data\reservationsystem.fdb;DataSource=192.168.43.227;
                Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=15;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;ServerType=0;";
        
               
        public OleDbConnection Accessconnection()
        {
            OleDbConnection connection = new OleDbConnection(access);
            return connection;
        }

        public OleDbCommand Accesslogin(string user, string password, OleDbConnection connection)
        {
            OleDbCommand cmd = new OleDbCommand("Select * from USERS where U_USERNAME=@user and U_PASSWORD=@password", connection);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@password", password);

            return cmd;
        }
        public OleDbCommand AccessForgotPassword(string user, string email, OleDbConnection connection)
        {
            OleDbCommand cmd = new OleDbCommand("Select * from USERS where U_USERNAME=@user and U_EMAIL=@email", connection);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@email", email);

            return cmd;
        }
        public OleDbCommand AccessChangePassword(string user, string newpassword, OleDbConnection connection)
        {
            OleDbCommand cmd = new OleDbCommand("UPDATE USERS SET U_PASSWORD =@newpassword where U_USERNAME=@user", connection);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@newpassword", newpassword);

            return cmd;
        }
        public OleDbCommand AccessGetAvailableItems(OleDbConnection connection)
        {
            OleDbCommand cmd = new OleDbCommand("select ITEMS.I_NAME, ITEMS.I_ID from ITEMS where ITEMS.I_STATE=\"1\"", connection);           
            return cmd;
        }

        public FbConnection FBconnection()
        {
            FbConnection connection = new FbConnection(Firebird);
            return connection;
        }

        public FbCommand FBuserlogin(string user, string password, FbConnection connection)
        {
            FbCommand cmd = new FbCommand("Select * from USERS where U_USERNAME=@user and U_PASSWORD=@password", connection);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@password", password);

            return cmd;
        }
       

        public FbCommand FBforgotpassword (string user, string email, FbConnection connection)
        {
            FbCommand cmd = new FbCommand("Select * from USERS where U_USERNAME=@user and U_EMAIL=@email", connection);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@email", email);

            return cmd;
        }
        public FbCommand FBchangepassword (string user, string newpassword, FbConnection connection)
        {
            FbCommand cmd = new FbCommand("UPDATE USERS SET U_PASSWORD =@newpassword where U_USERNAME=@user", connection);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@newpassword", newpassword);

            return cmd;
        }
    }
}
