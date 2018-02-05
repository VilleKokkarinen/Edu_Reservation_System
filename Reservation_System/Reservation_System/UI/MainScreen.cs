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
        public MainScreen()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            lbl_username.Text = Program.User.username();
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
    }
}
