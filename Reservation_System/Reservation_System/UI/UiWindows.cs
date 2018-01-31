using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation_System.UI
{
    class UiWindows
    {
        public RegisterUser _RegisterUserScreen = new RegisterUser();
        public LoginScreen _Loginscreen = new LoginScreen();        
        public MainScreen _Mainscreen = new MainScreen();
        public ForgotPasswordScreen _forgotpasswordscreen = new ForgotPasswordScreen();
        public NewItemScreen _newitemscreen = new NewItemScreen();
        public PreReservationScreen _prreservationscreen = new PreReservationScreen();
        public ReserationScreen _reservationscreen = new ReserationScreen();
        public ReturningScreen _returningscreen = new ReturningScreen();
        public SettingsScreen _settingscreen = new SettingsScreen();


        public void parentise()
        {
            _Mainscreen.Parent = _Loginscreen;
            _forgotpasswordscreen.Parent = _Loginscreen;
            _settingscreen.Parent = _Mainscreen;
        }
    }
}
