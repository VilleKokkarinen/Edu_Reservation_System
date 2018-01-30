using Reservation_System.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Reservation_System
{   
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