using Reservation_System.UI;
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
    public partial class SettingsScreen : Form
    {
        void language()
        {
            if (Program.Settings.English == true)
            {
                button11.Text = "Add new item to database";
                button12.Text = "Remove item from database";
                groupBox1.Text = "Language";
                rbEnglish.Checked = true;
              
            }
            else
            {
                button11.Text = "Lisää uusi tavara tietokantaan";
                button12.Text = "Poista tavara tietokannasta";
                groupBox1.Text = "Kieli";
                rbFinnish.Checked = true;
                
            }
        }
        public SettingsScreen()
        {
            InitializeComponent();
            CenterToScreen();
            language();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void rbEnglish_CheckedChanged(object sender, EventArgs e)
        {
            if(rbEnglish.Checked == true)
            {
                Program.Settings.English = true;
            }
            else
            {
                Program.Settings.English = false;
            }
            Program.Settings.SaveFile();
            Program.Settings.Checksettings();
        }

        private void rbFinnish_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEnglish.Checked == true)
            {
                Program.Settings.English = true;
            }
            else
            {
                Program.Settings.English = false;
            }
            Program.Settings.SaveFile();
            Program.Settings.Checksettings();
        }

        private void SettingsScreen_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
    }
}
