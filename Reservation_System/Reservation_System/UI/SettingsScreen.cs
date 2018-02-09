using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation_System
{
    public partial class SettingsScreen : Form
    {
        void language()
        {
            if (Program.Settings.English == true)
            {
                button11.Text = "Add new item to database";
                button12.Text = "Remove item from database";
                groupBox1.Text = "Language";
              
            }
            else
            {
                button11.Text = "Lisää uusi tavara tietokantaan";
                button12.Text = "Poista tavara tietokannasta";
                groupBox1.Text = "Kieli";
                
            }
        }
        public SettingsScreen()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

      
    }
}
