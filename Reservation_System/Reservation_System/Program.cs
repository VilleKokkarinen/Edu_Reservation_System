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
        [STAThread]
        static void Main(string[] args)
        {
            MySettings Settings = new MySettings();
            Settings.Checksettings();
            Settings.SaveFile();
            
            Application.EnableVisualStyles();

            //Creating all screens
            LoginScreen _Loginscreen = new LoginScreen();
            MainScreen _Mainscreen = new MainScreen();
            ForgotPasswordScreen _fpscreen = new ForgotPasswordScreen();
            NewItemScreen _newitemscreen = new NewItemScreen();
            PreReservationScreen _prreservationscreen = new PreReservationScreen();
            ReserationScreen _reservationscreen = new ReserationScreen();
            ReturningScreen _returningscreen = new ReturningScreen();
            SettingsScreen _settingscreen = new SettingsScreen();
            

            //show the first screen (login)
            _Loginscreen.ShowDialog();
        }
    }
}
