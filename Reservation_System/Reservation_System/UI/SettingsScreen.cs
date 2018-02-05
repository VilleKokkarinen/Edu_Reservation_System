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
        public SettingsScreen()
        {
            InitializeComponent();
            CenterToScreen();
        }
        void language()
        {
            if (Program.Settings.English == true)
            {
                btn_AddItem.Text = "Add new item to database";
                btn_DeleteItem.Text = "Delete item from database";
                grpBox_Language.Text = "Language";
                rBtn_LangEng.Text = "English";
                rBtn_LangFin.Text = "Suomi";
            }
            else
            {
                btn_AddItem.Text = "Lisää uusi tavara tietokantaan";
                btn_DeleteItem.Text = "Poista tavara tietokannasta";
                grpBox_Language.Text = "Kieli";
                rBtn_LangEng.Text = "English";
                rBtn_LangFin.Text = "Suomi";
            }
        }
        private void btn_AddItem_Click(object sender, EventArgs e)
        {

        }
    }
}
