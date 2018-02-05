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
    public partial class NewItemScreen : Form
    {
        public NewItemScreen()
        {
            InitializeComponent();
            CenterToScreen();
        }
        void language()
        {
            if (Program.Settings.English == true)
            {
                lbl_addnewitem.Text = "Add new item";
                lbl_name.Text = "Name";
                lbl_type.Text = "Type";
                lbl_ID.Text = "ID";
                btn_addtodatabase.Text = "Add to database";
            }
            else
            {
                lbl_addnewitem.Text = "Uuden tavaran lisääminen";
                lbl_ID.Text = "Tunniste";
                lbl_name.Text = "Nimi";
                lbl_type.Text = "Tyyppi";
                btn_addtodatabase.Text = "Lisää tietokantaan";
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {

        }
    }
}
