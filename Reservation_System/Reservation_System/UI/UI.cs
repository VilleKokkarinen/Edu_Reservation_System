using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation_System.UI
{
    class UserInterFace
    {
        private static UiWindows UI = new UiWindows();
       
        public static void LoginScreen()
        {
            UI._Loginscreen.ShowDialog();            
        }

        public static void MainScreen()
        {
            UI._Mainscreen.ShowDialog();
        }

        public static void ForgotPasswordScreen()
        {
            UI._forgotpasswordscreen.ShowDialog();
        }

        public static void RegisterUserScreen()
        {
            UI._RegisterUserScreen.ShowDialog();
        }

        public static void SettingsScreen()
        {
            UI._settingscreen.ShowDialog();
        }

        public static void ReservationScreen()
        {
            UI._reservationscreen.ShowDialog();
        }

        public static void PreReservationScreen()
        {
            UI._prreservationscreen.ShowDialog();
        }

        public static void NewItemScreen()
        {
            UI._newitemscreen.ShowDialog();
        }

        public static void ReturningScreen()
        {
            UI._returningscreen.ShowDialog();
        }
    }
}
