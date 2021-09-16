using MessageSystem.SMS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSystem.NET
{
    public class Program
    {
        static void Main(string[] args)
        {
            SMSRequest sms = new SMSRequest
            {
                from = "5548996673818",
                to = "5548996673818",
                text = "teste via integracao",
                tokenIntegrator = "d8e200e7717e9710245f87c3144d154c8d4a35a9"

            };

            var response = SMS.SMS.EmpresaSMS(SMS.Enum.EEmpresaSMS.DisparoPro).EnviaSMS(sms);
        }
    }
}
