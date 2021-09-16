using MessageSystem.SMS.DTO;
using System;
using System.Collections.Generic;
using System.Net;

namespace MessageSystem.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ////////////////////////////////////////////////////////////
                ///////////////////TESTE ENVIO DE EMAIL/////////////////////
                ////////////////////////////////////////////////////////////

                //var lstDestiny = new List<Destiny>
                //{
                //    new Destiny { Mail = "eduardonog1992@outlook.com", Name = "Eduardo" }
                //};
                //
                //var lstCCo = new List<Destiny>
                //{
                //    new Destiny { Mail = "eduardonog20@gmail.com", Name = "" }
                //};
                //
                //
                //Mail mail = new Mail
                //{
                //    ServerMail = new ServerMail
                //    {
                //        Host = "",
                //        Password = "",
                //        Port = 587,
                //        UserName = "",
                //        Ssl = false
                //    },
                //    Subject = "Test Subject",
                //    Body = "Test body",
                //    Priority = System.Net.Mail.MailPriority.Normal,
                //    IsBodyHtml = true,
                //    Destinies = lstDestiny,
                //    CCo = lstCCo
                //};
                //
                //Email.Email.SendMail(mail);

                ////////////////////////////////////////////////////////////
                ///////////////////TESTE ENVIO DE SMS///////////////////////
                ////////////////////////////////////////////////////////////

                //SMSRequest sms = new SMSRequest
                // {
                //     from = "5548996673818",
                //     to = "5548996673818",
                //     text = "teste via integracao",
                //     tokenIntegrator = "d8e200e7717e9710245f87c3144d154c8d4a35a9"

                //};

                //var response = SMS.SMS.EmpresaSMS(SMS.Enum.EEmpresaSMS.DisparoPro).EnviaSMS(sms);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
