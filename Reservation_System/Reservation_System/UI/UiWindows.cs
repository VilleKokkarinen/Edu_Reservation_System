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
        public MainScreen _Mainscreen = new MainScreen();
        public ForgotPasswordScreen _forgotpasswordscreen = new ForgotPasswordScreen();
        public NewItemScreen _newitemscreen = new NewItemScreen();
        public RemovingItemScreen _removeitemscreen = new RemovingItemScreen();
        public PreReservationScreen _prreservationscreen = new PreReservationScreen();
        public ReserationScreen _reservationscreen = new ReserationScreen();
        public ReturningScreen _returningscreen = new ReturningScreen();
        public SettingsScreen _settingscreen = new SettingsScreen();
        public AccountManagement _accounmanagementscreen = new AccountManagement();
        public ItemManagement _itemmanagementscreen = new ItemManagement();

        public void parentise()
        {
            _Mainscreen.Parent = _Loginscreen;
            _forgotpasswordscreen.Parent = _Loginscreen;
            _RegisterUserScreen.Parent = _Loginscreen;
            _settingscreen.Parent = _Mainscreen;
            _prreservationscreen.Parent = _Mainscreen;
            _reservationscreen.Parent = _Mainscreen;
            _returningscreen.Parent = _Mainscreen;
            _accounmanagementscreen.Parent = _Mainscreen;
            _itemmanagementscreen.Parent = _Mainscreen;
            _newitemscreen.Parent = _Mainscreen;
            _removeitemscreen.Parent = _Mainscreen;
        }            
    }
}
