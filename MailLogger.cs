using System;
using System.Net;
using System.Net.Mail;

namespace ELTSequencer
{
    public static class MailLogger
    {
        // Configure these settings according to your SMTP server
        private static readonly string SmtpServer = "smtp.example.com";
        private static readonly int SmtpPort = 587;
        private static readonly string SmtpUsername = "your-email@example.com";
        private static readonly string SmtpPassword = "your-password";
        private static readonly string FromEmail = "your-email@example.com";
        private static readonly string ToEmail = "recipient@example.com";

        public static void Log(string message)
        {
            try
            {
                using (var smtpClient = new SmtpClient(SmtpServer, SmtpPort))
                {
                    smtpClient.EnableSsl = true;
                    smtpClient.Credentials = new NetworkCredential(SmtpUsername, SmtpPassword);

                    var mailMessage = new MailMessage
                    {
                        From = new MailAddress(FromEmail),
                        Subject = "ELTSequencer Command Log",
                        Body = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}",
                        IsBodyHtml = false,
                    };
                    mailMessage.To.Add(ToEmail);

                    smtpClient.Send(mailMessage);
                }
            }
            catch (Exception ex)
            {
                // Fallback to file logging if email fails
                FileLogger.Log($"MailLogger failed: {ex.Message}");
            }
        }
    }
}