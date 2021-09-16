using MessageSystem.SMS.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MessageSystem.SMS.Interface
{
    public interface ISMS
    {
        string EnviaSMS(SMSRequest sms);
    }
}
