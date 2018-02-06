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
        void language()
        {
            if (Program.Settings.English == true)
            {
                label23.Text = "Search";
                button17.Text = "Reserve";
                button18.Text = "Show item details";
            }
            else
            {
                label23.Text = "Hae tavaroita";
                button17.Text = "Varaa";
                button18.Text = "Näytä valitun tavaran tiedot";
            }
        }
        public PreReservationScreen()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }
    }
}
