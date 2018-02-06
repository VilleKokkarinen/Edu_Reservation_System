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
    public partial class RemovingItemScreen : Form
    {
        void language()
        {
            if (Program.Settings.English == true)
            {
                label19.Text = "Removing items";
                label20.Text = "Search items";
                button15.Text = "Search";
                button14.Text = "Remove selected item";
            }
            else
            {
                label19.Text = "Tavaran poistaminen";
                label20.Text = "Hae tavaroita";
                button15.Text = "Hae";
                button14.Text = "Poista valittu tuote";
            }
        }

        public RemovingItemScreen()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }
    }
}
