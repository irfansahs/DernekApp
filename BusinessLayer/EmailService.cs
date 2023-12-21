using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{

    public class EmailMessage
    {
        public string FromAddress { get; set; }
        public string Password { get; set; }
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }

    public class EmailService
    {
        public void SendEmail(EmailMessage email)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(email.FromAddress);
                mail.To.Add(email.ToAddress);
                mail.Subject = email.Subject;
                mail.Body = email.Body;

                SmtpClient smtp = new SmtpClient("smtp.example.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential(email.FromAddress, email.Password);
                smtp.EnableSsl = true;

                smtp.Send(mail);

                Console.WriteLine("E-posta başarıyla gönderildi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }
        }
    }
}
