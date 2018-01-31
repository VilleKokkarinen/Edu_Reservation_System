using Reservation_System.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.Client;
using FirebirdSql.Data.FirebirdClient;
using System.Data.OleDb;

namespace Reservation_System
{   
    class SQL
    {
        string access = @"Provider=Microsoft.ACE.OLEDB.12.0;DataSource=|DataDirectory|\Access\reservationsystem.accdb";
        string Firebird = @"User=SYSDBA;Password=kokkarinen;Database=192.168.43.227:D:\data\reservationsystem.fdb;DataSource=192.168.43.227;
                Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=15;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;ServerType=0;";


        public FbConnection FBconnection()
        {
            FbConnection connection = new FbConnection(Firebird);
            return connection;
        }

        public OleDbConnection Accessconnection()
        {
            OleDbConnection connection = new OleDbConnection(access);
            return connection;
        }
       
        public FbCommand userlogin(string user, string password,FbConnection connection)
        {
            FbCommand cmd = new FbCommand("Select * from USERS where U_USERNAME=@username and U_PASSWORD=@password", connection);
            cmd.Parameters.AddWithValue("@username", user);
            cmd.Parameters.AddWithValue("@password", password);

            return cmd;
        }

    }

    class Program
    {
        public static MySettings Settings = new MySettings();
        

        [STAThread]
        static void Main(string[] args)
        {
            Settings.Checksettings();
            Settings.SaveFile();

            Application.EnableVisualStyles();
            
            //show the first screen (login)
            UserInterFace.LoginScreen();
            
        }
    }
}