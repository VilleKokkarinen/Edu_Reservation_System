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
    public partial class AccountManagement : Form
    {
       
        public AccountManagement()
        {
            InitializeComponent();
            language();
        }
        void language()
        {
            if (Program.Settings.English == true)
            {
                lbl_confirmpassword.Text = "Confirm password";
                lbl_newemail.Text = "New email";
                lbl_newpassword.Text = "New password";
                groupBox1.Text = "Change Password";
                groupBox2.Text = "Change email-address";
                btn_applychanges.Text = "Apply Changes";
                btn_applychanges2.Text = "Apply Changes";
            }
            else
            {
                lbl_confirmpassword.Text = "Vahvista salasana";
                lbl_newemail.Text = "Uusi sähköposti";
                lbl_newpassword.Text = "Uusi salasana";
                groupBox1.Text = "Vaihda salasana";
                groupBox2.Text = "Vaihda sähköposti- osoite";
                btn_applychanges.Text = "Hyväksy muutokset";
                btn_applychanges2.Text = "Hyväksy muutokset";
            }
        }

        private void AccountManagement_Load(object sender, EventArgs e)
        {

        }

        private void btn_applychanges2_Click(object sender, EventArgs e)
        {
            //Change email
        }

        private void btn_applychanges_Click(object sender, EventArgs e)
        {
            if(txt_newpassword.Text == txt_confirmpassword.Text)
            {
                //change password
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
