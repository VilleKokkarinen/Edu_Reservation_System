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
    public partial class PreReservationScreen : Form
    {
        public PreReservationScreen()
        {
            InitializeComponent();
            CenterToScreen();
        }
        void language()
        {
            if (Program.Settings.English == true)
            {
                lbl_PreReservationMenu.Text = "Prereservation menu";
                lbl_Search.Text = "Search item";
                btn_Reserve.Text = "Reserve";
                btn_Search.Text = "Search";
                btn_ShowItemInfo.Text = "Show selected item info";
            }
            else
            {
                lbl_PreReservationMenu.Text = "Ennakkovarausvalikko";
                lbl_Search.Text = "Hae tavara";
                btn_Reserve.Text = "Varaa";
                btn_Search.Text = "Hae";
                btn_ShowItemInfo.Text = "Näytä valitun tavaran tiedot";
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {

        }
    }
}
