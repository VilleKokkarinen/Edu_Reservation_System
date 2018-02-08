using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Reservation_System.UI
{
    public partial class ReturningScreen : Form
    {
        void language()
        {
            if (Program.Settings.English == true)
            {
                label7.Text = "Return window";
                label8.Text = "Borrowed items";               
                button7.Text = "Return";                
                button10.Text = "Show information about item";
            }
            else
            {
                label7.Text = "Palautusvalikko";
                label8.Text = "Lainassa olevat tuotteet";               
                button7.Text = "Palauta";               
                button10.Text = "Näytä valitun tavaran tiedot";
            }

        }
        public ReturningScreen()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void ReturningScreen_Load(object sender, EventArgs e)
        {
            checkedListBox2.Items.Clear();
            foreach (User.LoanItem loan in Program.user.Loans)
            {
                checkedListBox2.Items.Add(loan.Description);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
    
}
