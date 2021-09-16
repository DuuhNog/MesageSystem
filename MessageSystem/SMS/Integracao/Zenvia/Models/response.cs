using System;
using System.Collections.Generic;
using System.Text;

namespace MessageSystem.SMS.Integracao.Zenvia.Models
{
    public class response
    {
        public string code { get; set; }
        public string message { get; set; }
        public List<Detail> details { get; set; }

        public class Detail
        {
            public string code { get; set; }
            public string path { get; set; }
            public string message { get; set; }
        }

    }
}
