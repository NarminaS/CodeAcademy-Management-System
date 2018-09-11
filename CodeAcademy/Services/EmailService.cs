using MimeKit;
using System;
using System.Threading.Tasks;
using MailKit.Net.Smtp;

namespace CodeAcademy.Services
{
    public class EmailService
    {
        public async Task SendEmailAsync(string name, string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("CodeAcademy Administration", "narmings@code.edu.az"));
            emailMessage.To.Add(new MailboxAddress(name, email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                try
                {
                    await client.ConnectAsync("smtp.gmail.com", 587, false);
                    await client.AuthenticateAsync("narmings@code.edu.az", "taurus91");
                    await client.SendAsync(emailMessage);

                    await client.DisconnectAsync(true);
                }
                catch (Exception ex)
                {
                    //
                }
            }
        }
    }
}
