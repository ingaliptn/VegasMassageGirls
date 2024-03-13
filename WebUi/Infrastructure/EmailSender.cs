using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.IO;
using System.Threading.Tasks;
using MailKit.Security;
using WebUi.Models;

//https://kenhaggerty.com/articles/article/aspnet-core-22-smtp-emailsender-implementation
namespace WebUi.Infrastructure
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
        Task SendEmailFileAsync(string email, string subject, string message, string path);
    }

    public class EmailSender : IEmailSender
    {
        private readonly EmailSettings _emailSettings;

        public EmailSender(
            IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            try
            {
                var mimeMessage = new MimeMessage();

                mimeMessage.From.Add(new MailboxAddress(_emailSettings.SenderName, _emailSettings.Sender));

                mimeMessage.To.Add(new MailboxAddress(email));

                mimeMessage.Subject = subject;

                mimeMessage.Body = new TextPart("html")
                {
                    Text = message
                };

                using var client = new MailKit.Net.Smtp.SmtpClient();
          
                // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                //await client.ConnectAsync(_emailSettings.MailServer, _emailSettings.MailPort, SecureSocketOptions.None);
                await client.ConnectAsync(_emailSettings.MailServer, _emailSettings.MailPort);

                // Note: only needed if the SMTP server requires authentication
                await client.AuthenticateAsync(_emailSettings.Sender, _emailSettings.Password);


                await client.SendAsync(mimeMessage);

                await client.DisconnectAsync(true);
            }
            catch (Exception ex)
            {
                var d = ex.Message;
            }
        }

        public async Task SendEmailFileAsync(string email, string subject, string message, string path)
        {
            try
            {
                var mimeMessage = new MimeMessage();

                mimeMessage.From.Add(new MailboxAddress(_emailSettings.SenderName, _emailSettings.Sender));

                mimeMessage.To.Add(new MailboxAddress(email));

                mimeMessage.Subject = subject;

                //mimeMessage.Body = new TextPart("html")
                //{
                //    Text = message
                //};

                // create our message text, just like before (except don't set it as the message.Body)
                var body = new TextPart("html")
                {
                    Text = message
                };

                var attachment = new MimePart("image", "gif")
                {
                    Content = new MimeContent(File.OpenRead(path)),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = Path.GetFileName(path)
                };
                // now create the multipart/mixed container to hold the message text and the
                // image attachment
                var multipart = new Multipart("mixed");
                multipart.Add(body);
                multipart.Add(attachment);

                // now set the multipart/mixed as the message body
                mimeMessage.Body = multipart;

                using var client = new MailKit.Net.Smtp.SmtpClient();

                // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                //await client.ConnectAsync(_emailSettings.MailServer, _emailSettings.MailPort, SecureSocketOptions.None);
                await client.ConnectAsync(_emailSettings.MailServer, _emailSettings.MailPort);

                // Note: only needed if the SMTP server requires authentication
                await client.AuthenticateAsync(_emailSettings.Sender, _emailSettings.Password);


                await client.SendAsync(mimeMessage);

                await client.DisconnectAsync(true);
            }
            catch (Exception ex)
            {
                var d = ex.Message;
            }
        }
    }
}
