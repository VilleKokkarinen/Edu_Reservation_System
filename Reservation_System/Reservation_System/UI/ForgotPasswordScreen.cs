using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

using MySql.Data.MySqlClient;

namespace Reservation_System.UI
{
    public partial class ForgotPasswordScreen : Form
    {
        string newpassword = "";

        public ForgotPasswordScreen()
        {
            InitializeComponent();
            CenterToScreen();             
        }

        private void checkuser()
        {
            Cursor = Cursors.WaitCursor;
            try
            {

                MySqlConnection connection = Program.sql.MySqlConnection();
                MySqlCommand cmd = Program.sql.MySqlLogin(txt_username.Text, txt_email.Text, connection);

                connection.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                connection.Close();

                int count = ds.Tables[0].Rows.Count;
               
                if (count == 1)
                {                   
                    this.Hide();
                    newpassword = "kokkarinen";

                    changepassword();
                    email();

                }
                else
                {
                    MessageBox.Show("No user found with provided information");
                }
            }
            catch
            {
                //do something with the error code ex
            }


            Cursor = Cursors.Default;
        }

        private void changepassword()
        {

            using (MySqlConnection connection = Program.sql.MySqlConnection())
            {
                using (MySqlCommand cmdnewpw = Program.sql.MySqlLogin(txt_username.Text, newpassword, connection))
                {
                    connection.Open();

                    int result = cmdnewpw.ExecuteNonQuery();

                    connection.Close();

                    if (result < 0)
                    {
                        MessageBox.Show("Error changing password");
                    }
                    else
                    {
                        MessageBox.Show("User: " + txt_username.Text + "'s\n New password has been sent to their email address!");
                    }
                }
            }
        }

        private void email()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("reservationsystem.forgotpw@gmail.com");
            mail.To.Add(txt_email.Text);
            mail.Subject = "Password reset request";
            mail.Body = "You've requested a password change.\n"+
                        "Here is your new password:"+ newpassword;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("reservationsystem.forgotpw@gmail.com", "aaaaaaaaaa!#");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);          
        }



        private void button1_Click(object sender, EventArgs e)
        {
            checkuser();
                   
        }
    }
}
