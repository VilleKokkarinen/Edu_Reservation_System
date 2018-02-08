using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation_System.UI
{
    public partial class MainScreen : Form
    {
        void language()
        {
            if (Program.Settings.English == true)
            {
                btn_Loan.Text = "Loan item(s)";
                btn_reserve.Text = "Return loan(s)";
                btn_return.Text = "Reservation";
                btn_accountmngr.Text = "Account Managment";
                btn_settings.Text = "Settings";
            }
            else
            {
                btn_Loan.Text = "Lainaa tavara";
                btn_reserve.Text = "Palauta lainaus";
                btn_return.Text = "Varaus *?*";
                btn_accountmngr.Text = "Tilin hallinta";
                btn_settings.Text = "Asetukset";
            }
        }
        public MainScreen()
        {
            InitializeComponent();
            CenterToScreen();
        }
        void language()
        {
            if (Program.Settings.English == true)
            {
                lbl_username.Text = "Username";
                lbl_welcome.Text = "Logged in as";
                btn_accountmngr.Text = "Account managment";
                btn_Loan.Text = "Loan";
                btn_reserve.Text = "Reserve";
                btn_return.Text = "Return";
                btn_settings.Text = "Settings";
            }
            else
            {
                lbl_username.Text = "Käyttäjänimi";
                lbl_welcome.Text = "Kirjautunut sisään käyttäjänä";
                btn_accountmngr.Text = "Tilin hallinta";
                btn_Loan.Text = "Lainaa";
                btn_reserve.Text = "Varaa";
                btn_return.Text = "Palauta";
                btn_settings.Text = "Asetukset";
            }
        }
        private void MainScreen_Load(object sender, EventArgs e)
        {
            lbl_username.Text = User.User._username;
        }

        private void btn_Loan_Click(object sender, EventArgs e)
        {
            UserInterFace.ReservationScreen();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            UserInterFace.ReturningScreen();
        }

        private void btn_reserve_Click(object sender, EventArgs e)
        {
            UserInterFace.PreReservationScreen();
        }

        private void btn_accountmngr_Click(object sender, EventArgs e)
        {
            UserInterFace.AccountManagementScreen();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            UserInterFace.SettingsScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserInterFace.ItemManagementScreen();
        }
    }
}
