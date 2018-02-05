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
        public RemovingItemScreen()
        {
            InitializeComponent();
            CenterToScreen();
        }
        void language()
        {
            if (Program.Settings.English == true)
            {
                lbl_SearchItem.Text = "Search item";
                checkboxlist_DeleteItem.Text = "Delete item";
                btn_Delete.Text = "Delete";
                btn_SearchItem.Text = "Search";
            }
            else
            {
                lbl_SearchItem.Text = "Hae tavara";
                checkboxlist_DeleteItem.Text = "Poista tavara";
                btn_Delete.Text = "Poista";
                btn_SearchItem.Text = "Hae";
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
