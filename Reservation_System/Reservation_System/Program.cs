using Reservation_System.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Reservation_System
{   
    class Program
    {
        public static SQL sql = new SQL();
        public static MySettings Settings = MySettings.LoadFile();
        public static User.User user;        

        [STAThread]
        static void Main(string[] args)
        {                       
            Settings.Checksettings();
            Settings.SaveFile();

            Application.EnableVisualStyles();

            try
            {
                //show the first screen (login)
                UserInterFace.LoginScreen();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}