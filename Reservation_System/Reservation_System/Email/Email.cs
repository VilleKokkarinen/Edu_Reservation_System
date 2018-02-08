using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Reservation_System.Email
{
    class Email
    {
        private MailMessage mail = new MailMessage();
        private SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
        
        public Email(string recipient, string subject, string message)
        {
            mail.From = new MailAddress("reservationsystem.forgotpw@gmail.com");
            mail.To.Add(recipient);
            mail.Subject = subject;
            mail.Body = message;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("reservationsystem.forgotpw@gmail.com", "aaaaaaaaaa!#");
            SmtpServer.EnableSsl = true;
        }

        public void send()
        {
            SmtpServer.Send(mail);
        }
    }
}
