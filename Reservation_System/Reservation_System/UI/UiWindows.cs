using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation_System.UI
{
    class UiWindows
    {
        public LoginScreen _Loginscreen = new LoginScreen();
        public RegisterUser _RegisterUserScreen = new RegisterUser();       
        public ForgotPasswordScreen _forgotpasswordscreen = new ForgotPasswordScreen();

        public void parentise()
        {           
            _forgotpasswordscreen.Parent = _Loginscreen;
            _RegisterUserScreen.Parent = _Loginscreen;           
        }            
    }
}
