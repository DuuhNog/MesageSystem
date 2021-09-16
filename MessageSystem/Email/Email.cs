using MessageSystem.Email.DTO;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace MessageSystem.Email
{
    public static class Email
    {
        public static void SendMail(Mail mailrequest)
        {
            SmtpClient client = new SmtpClient
            {
                Host = mailrequest.ServerMail.Host,
                EnableSsl = mailrequest.ServerMail.Ssl,
                Credentials = new System.Net.NetworkCredential(mailrequest.ServerMail.UserName, mailrequest.ServerMail.Password),
                Port = mailrequest.ServerMail.Port
            };

            MailMessage mail = new MailMessage
            {
                Sender = new MailAddress(mailrequest.ServerMail.UserName),
                From = new MailAddress(mailrequest.ServerMail.UserName)
            };


            if (mailrequest.Destinies != null)
            {
                foreach (Destiny d in mailrequest.Destinies)
                    mail.To.Add(new MailAddress(d.Mail, d.Name == "" ? d.Mail : d.Name));
            }

            if (mailrequest.CCo != null)
            {
                foreach (Destiny d in mailrequest.Destinies)
                    mail.Bcc.Add(new MailAddress(d.Mail, d.Name == "" ? d.Mail : d.Name));
            }


            mail.Subject = mailrequest.Subject;
            mail.Body = mailrequest.Body;
            mail.IsBodyHtml = mailrequest.IsBodyHtml;
            mail.Priority = mailrequest.Priority;
            try
            {
                client.Send(mail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
