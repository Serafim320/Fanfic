using MimeKit;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace fanfic.by.Models
{
    public class EmailService
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            SmtpClient client = new SmtpClient("smtp.mail.ru");
            client.EnableSsl = true;

            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("fanfic.by@mail.ru", "Password111222");

            MailMessage mailMessage = new MailMessage();
            mailMessage.IsBodyHtml = true;

            mailMessage.From = new MailAddress("fanfic.by@mail.ru","Fanfic.by");
            mailMessage.To.Add(email);

            mailMessage.Body = message;
            mailMessage.Subject = "Подтвердите свой email в Fanfic.by";
            client.Send(mailMessage);
        }
    }
}
