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
    public partial class MainScreenOLD : Form
    {
        void language()
        {
            if (Program.Settings.English == true)
            {
                btn_Loan.Text = "Loan item(s)";
                btn_reserve.Text = "Return loan(s)";
                btn_return.Text = "Reservation";
                btn_accountmngr.Text = "Account Managment";
                button1.Text = "Item Managment";
                btn_settings.Text = "Settings";
            }
            else
            {
                btn_Loan.Text = "Lainaa tavara";
                btn_reserve.Text = "Palauta lainaus";
                btn_return.Text = "Varaus *?*";
                btn_accountmngr.Text = "Tilin hallinta";
                button1.Text = "Tavaran hallinta";
                btn_settings.Text = "Asetukset";
            }
        }
        public MainScreenOLD()
        {
            InitializeComponent();
            CenterToScreen();
            language();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            lbl_username.Text = User.User._username;
        }

        private void btn_Loan_Click(object sender, EventArgs e)
        {
           // this.Close();
            UserInterFace.ReservationScreen();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
           // this.Close();           
            UserInterFace.ReturningScreen();
        }

        private void btn_reserve_Click(object sender, EventArgs e)
        {
           // this.Close();
            UserInterFace.PreReservationScreen();
        }

        private void btn_accountmngr_Click(object sender, EventArgs e)
        {
           // this.Close();
            UserInterFace.AccountManagementScreen();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
           // this.Close();
            UserInterFace.SettingsScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();            
            UserInterFace.ItemManagementScreen();
        }

        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure you want to exit?", "!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (exit == DialogResult.No);
        }
    }
}
