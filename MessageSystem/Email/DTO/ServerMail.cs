using System;
using System.Collections.Generic;
using System.Text;

namespace MessageSystem.Email.DTO
{
    public class ServerMail
    {
        public string Host { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }
        public bool Ssl { get; set; }
    }
}
