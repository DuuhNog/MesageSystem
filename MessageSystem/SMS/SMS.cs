using MessageSystem.SMS.Enum;
using MessageSystem.SMS.Integracao.DisparoPRO;
using MessageSystem.SMS.Integracao.Zenvia;
using MessageSystem.SMS.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MessageSystem.SMS
{
    public static class SMS
    {
        public static ISMS EmpresaSMS(EEmpresaSMS eEmpresaSMS)
        {
            switch (eEmpresaSMS)
            {
                case EEmpresaSMS.Zenvia:
                    return new Zenvia();
                case EEmpresaSMS.DisparoPro:
                    return new DisparoPRO();
                default:
                    throw new Exception("Empresa não homologada!");
            }
        }
    }
}
