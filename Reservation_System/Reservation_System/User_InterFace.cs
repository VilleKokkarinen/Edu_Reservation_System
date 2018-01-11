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
    public partial class User_InterFace : Form
    {
        public User_InterFace()
        {
            InitializeComponent();
        }

        private void User_InterFace_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Program started!\n Calculating current DateTime...");
            DateTime now = DateTime.Now;
            TimeSpan time = new TimeSpan(14, 0, 0, 0);
            now = now.Add(time);

            DTPend.Value = now.Date;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Entering the Settings page.");
            Settings settings = new Settings();
            settings.Show();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
           
            btnCreateItem.Enabled = false;

            if (txtPassword.Text == "Admin")
            {
                Console.WriteLine("Access to the Item Page granted");
                btnCreateItem.Enabled = true;
            }          
                
        }
    }
}
