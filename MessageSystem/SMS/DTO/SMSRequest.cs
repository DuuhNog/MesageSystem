using System;
using System.Collections.Generic;
using System.Text;

namespace MessageSystem.SMS.DTO
{
    public class SMSRequest
    {
        public string from { get; set; }
        public string to { get; set; }
        public string text { get; set; }
        public string tokenIntegrator { get; set; }

    }
}
