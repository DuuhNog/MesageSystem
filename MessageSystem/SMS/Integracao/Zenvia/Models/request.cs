using System;
using System.Collections.Generic;
using System.Text;

namespace MessageSystem.SMS.Integracao.Zenvia.Models
{
    public class request
    {
        public string from { get; set; }
        public string to { get; set; }
        public contents contents { get; set; }
    }
}
