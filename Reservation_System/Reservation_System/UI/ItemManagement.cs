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
    public partial class ItemManagement : Form
    {
        void language()
        {
            if (Program.Settings.English == true)
            {
                btn_addnewitem.Text = "Add new item";
                btn_removeitem.Text = "Remove item";
            }

            else

            {
                btn_addnewitem.Text = "Lisää tavara";
                btn_removeitem.Text = "Poista tavara";
            }
        }
        public ItemManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserInterFace.NewItemScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserInterFace.RemovingItemScreen();
        }
    }
}
