using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

                mail.From = new MailAddress("ddernekuygulamasi@gmail.com", "Dernek projesi");
                mail.To.Add(email.ToAddress);
                mail.Subject = "Dernek uygulaması";
                mail.Subject = email.Subject;

                mail.Body = email.Body;


                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("ddernekuygulamasi@gmail.com", "xvmgopvtfymikpxm"),
                    EnableSsl = true,
                };

                smtpClient.Send(mail);

                Console.WriteLine("E-posta başarıyla gönderildi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }
        }
    }
}
