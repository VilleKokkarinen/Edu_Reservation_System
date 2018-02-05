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

        private void ReturningScreen_Load(object sender, EventArgs e)
        {
            foreach (User.LoanItem loan in Program.user.Loans)
            {
                checkedListBox2.Items.Add(loan.Description);
            }
        }
    }
}
