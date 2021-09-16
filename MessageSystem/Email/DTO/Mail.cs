using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace MessageSystem.Email.DTO
{
    public class Mail
    {
        public ServerMail ServerMail { get; set; }
        public List<Destiny> Destinies { get; set; }
        public List<Destiny> CCo { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsBodyHtml { get; set; }
        public MailPriority Priority { get; set; }

    }
}
