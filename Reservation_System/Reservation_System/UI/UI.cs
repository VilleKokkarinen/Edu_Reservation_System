using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
