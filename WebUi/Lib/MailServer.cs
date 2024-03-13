using System;
using System.Net;
using System.Net.Mail;
using WebUi.Lib;
using WebUi.Models;

namespace WebUi.lib
{
    public class MailServer
    {
        public static string SendMessage(MailModel m)
        {
            if (!WorkLib.IsValidEmail(m.ToEmail)) return "Error email address";
            var message = new MailMessage
            {
                From = new MailAddress(m.FromEmail, m.FromName),
                Subject = m.Subject,
                Body = m.Body,
                IsBodyHtml = true
            };
            message.To.Add(new MailAddress(m.ToEmail));
            var client = new SmtpClient
            {
                Host = m.Smtp,
                Port = m.Port,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = true,
                Credentials = new NetworkCredential(m.Login, m.Password)
            };
            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return "True";
        }
    }
}
