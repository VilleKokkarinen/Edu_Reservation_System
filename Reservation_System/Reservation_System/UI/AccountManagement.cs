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
        void language()
        {
            if (Program.Settings.English == true)
            {
                label1.Text = "Change password";
                label2.Text = "New password";
                label3.Text = "Confirm password";
                label6.Text = "Change email";
                label5.Text = "New email";
                button1.Text = "Submit changes";
                button2.Text = "Submit changes";

            }
            else
            {
                label1.Text = "Vaihtaa salasana";
                label2.Text = "Uusi salasana";
                label3.Text = "Vahvista salasana";
                label6.Text = "Vahtaa sähköposti";
                label5.Text = "Uusi sähköposti";
                button1.Text = "Hyväksy muutokset";
                button2.Text = "Hyväksy muutokset";
            }
        }
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
