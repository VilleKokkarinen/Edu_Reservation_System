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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            lbl_username.Text = Program.User.username();
        }

        private void btn_Loan_Click(object sender, EventArgs e)
        {
           
        }
    }
}
