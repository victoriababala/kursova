using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonFood_Utility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //    var emailToSend = new MimeMessage();
            //    emailToSend.From.Add(MailboxAddress.Parse("hello@dotnetmastery.com"));
            //    emailToSend.To.Add(MailboxAddress.Parse(email));
            //    emailToSend.Subject = subject;
            //    emailToSend.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = htmlMessage };

            //    // send email

            //    using (var emailClient = new SmtpClient())
            //    {
            //        emailClient.Connect("smtp.rambler.ru", 465, MailKit.Security.SecureSocketOptions.StartTls);
            //        emailClient.Authenticate("testfordotnet@rambler.ru", "pDrHWu6Gm9Uvzx)");
            //        emailClient.Send(emailToSend);
            //        emailClient.Disconnect(true);
            //    }
            return Task.CompletedTask;
        }
    }
}
