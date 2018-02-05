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
    public partial class ReturningScreen : Form
    {
        public ReturningScreen()
        {
            InitializeComponent();
            CenterToScreen();
        }
        void language()
        {
            if (Program.Settings.English == true)
            {
                lbl_SearchItems.Text = "Search item";
                lbl_ItemsLoaned.Text = "Loaned item's";
                lbl_ReturnMenu.Text = "Return menu";
                btn_Return.Text = "Return";
                btn_Search.Text = "Search";
                btn_ShowItemInfo.Text = "Show selected item info";
            }
            else
            {
                lbl_SearchItems.Text = "Hae tavara";
                lbl_ItemsLoaned.Text = "Lainassa olevat tavarat";
                lbl_ReturnMenu.Text = "Palautusvalikko";
                btn_Return.Text = "Palauta";
                btn_Search.Text = "Hae";
                btn_ShowItemInfo.Text = "Näytä valitun tavaran tiedot";
            }
        }
        private void ReturningScreen_Load(object sender, EventArgs e)
        {

        }

        private void btn_Return_Click(object sender, EventArgs e)
        {

        }
    }
}
