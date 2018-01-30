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

namespace Reservation_System.UI
{
    public partial class ForgotPasswordScreen : Form
    {        
        
        public ForgotPasswordScreen()
        {
            InitializeComponent();
            CenterToScreen();             
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("reservationsystem.forgotpw@gmail.com");
            mail.To.Add("p119992@edu.sakky.fi");
            mail.Subject = "Test Mail";
            mail.Body = "This is an sample text email from my software. \n get to work boi";

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("reservationsystem.forgotpw@gmail.com", "aaaaaaaaaa!#");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            MessageBox.Show("mail Send");
        }
    }
}
