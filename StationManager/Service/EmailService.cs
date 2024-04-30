using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Service
{
    public static class EmailService
    {
        public static string Address = "yamchahuyvs@gmail.com"; //Địa chỉ email của bạn
        public static string Password = "nbkfrmilgukmjdnp"; //Mật khẩu ứng dụng

        public static void Send(List<string> sendTo, string subject, string message)
        {
            using (SmtpClient smtp = new SmtpClient())
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential(Address, Password);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(Address);
                foreach (string s in sendTo)
                {
                    mail.To.Add(new MailAddress(s));
                }
                mail.IsBodyHtml = true;
                mail.Subject = subject;
                mail.Body = message;
                smtp.Send(mail);
            }
            //using (SmtpClient smtp = new SmtpClient())
            //{
            //    smtp.Host = "smtp.gmail.com";
            //    smtp.Port = 587;
            //    smtp.EnableSsl = true;
            //    smtp.Credentials = new NetworkCredential(Address, Password);
            //    smtp.SendAsync(Address, sendTo, subject, message, null);
            //}
        }
        public static void Send(string sendTo, string subject, string message)
        {
            using (SmtpClient smtp = new SmtpClient())
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential(Address, Password);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(Address);
                mail.To.Add(new MailAddress(sendTo));
                mail.IsBodyHtml = true;
                mail.Subject = subject;
                mail.Body = message;
                smtp.Send(mail);
            }
        }
        public static void sendMailOTP(string to, string OTP)
        {
            Task send = new Task(() =>
            {
                Send(to, "Verify mail", "Verify your mail with code: " + OTP);
            });
            send.Start();
        }
    }
}
