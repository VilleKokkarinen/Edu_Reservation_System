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
        public static void ForgotPasswordScreen()
        {
            UI._forgotpasswordscreen.ShowDialog();
        }

        public static void RegisterUserScreen()
        {
            UI._RegisterUserScreen.ShowDialog();
        }
    }
}
