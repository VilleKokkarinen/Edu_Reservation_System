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
    class Program
    {
        public static MySettings Settings = MySettings.LoadFile();
        public static User User;

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